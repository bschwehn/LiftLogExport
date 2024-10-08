﻿using System.Text;
using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using Scriban.Syntax;

namespace LiftLog.Backup;

public class TemplateExport : IExport
{

    public class TemplateModel()
    {

        public record Daily(string Day, List<ExerciseRecord> Records);

        public List<ExerciseRecord> AllExercises { get; set; }

        public SortedDictionary<DateOnly, List<ExerciseRecord>> DailyExercises 
        {
            get
            {
                Dictionary<DateOnly, List<ExerciseRecord>> group = AllExercises
                    .GroupBy(e => e.Date)
                    .ToDictionary(g => g.Key, g => g.ToList());

                return new(group);
            }
        }
    }

    public class Functions() : ScriptObject
    {
        public static string FormatDate(DateOnly date) => date.ToString("yyyy-MM-dd");
        public static string Pad(string input, string member)
        {
            return input;
        }
        public static string Pad2(TemplateContext context, SourceSpan span, string input, string member)
        {
            return input;
        }

        public static string OrgTable(List<ExerciseRecord> records)
        {
            StringBuilder sb = new();
            string[] names = records.Select(r => r.ExerciseName).ToArray();
            string[] weights = records.Select(r => r.Weight.ToString()).ToArray();
            string[] targets = records.Select(r => r.TargetReps.ToString()).ToArray();
            string[] reps = records.Select(r => r.ActualReps.ToString()).ToArray();
            string[] dates = records.Select(r => r.Date.ToString("yyyy-MM-dd")).ToArray();
            string[] times = records.Select(r => r.Time.ToString("HH:mm")).ToArray();
            string[] notes = records.Select(r => r.Notes).ToArray();

            List<(string, string[], bool)> cols = new()
            {
                ("Date", dates, false),
                ("Time", times, false),
                ("Exercise", names, false),
                ("Target Reps", targets, true),
                ("Reps", reps, true),
                ("Weight", weights, true),
                ("Notes", notes, false),
            };

            List<int> maxLengths = cols.Select(c => GetMaxLength(c.Item1, c.Item2)).ToList();

            for (int i = 0; i < maxLengths.Count; i++)
            {
                sb.Append(AddOrgCol(cols[i].Item1, maxLengths[i], cols[i].Item3));
            }

            sb.AppendLine("|");

            DateOnly lastDay = DateOnly.MinValue;

            for (int r = 0; r < records.Count; r++)
            {
                if (records[r].Date > lastDay)
                {
                    lastDay = records[r].Date;
                    AddSeparator(sb, maxLengths);
                }
                for (int i = 0; i < maxLengths.Count; i++)
                {
                    sb.Append(AddOrgCol(cols[i].Item2[r], maxLengths[i], cols[i].Item3));
                }

                sb.AppendLine("|");
            }

            return sb.ToString();
        }

        private static void AddSeparator(StringBuilder sb, List<int> maxLengths)
        {
            for (int i = 0; i < maxLengths.Count; i++)
            {
                sb.Append(AddOrgSeparator(maxLengths[i]));
            }

            sb.AppendLine("|");
        }

        private static int GetMaxLength(string header, string[] values) =>
            Math.Max(header.Length, values.MaxBy(v => v.Length)?.Length ?? 0);

        private static string AddOrgCol(string v, int max, bool alignRight)
        {
            int padEnd = max - v.Length + 1;
            string padding = new(' ', padEnd);
            v = v.Replace("\n", " ").Trim();
            return alignRight ? $"|{padding}{v} " : $"| {v}{padding}";
        }

        private static string AddOrgSeparator(int max)
        {
            string padding = new('-', max + 2);
            return $"|{padding}";
        }
    }

    public void ExportExercises(ExportOptions options, List<ExerciseRecord> exercises, StreamWriter writer)
    {
        Template template = LoadTemplate(options);
        TemplateModel model = GetTemplateModel(options, exercises);
        TemplateContext context = new()
        {
            MemberRenamer = m => m.Name,
            NewLine = Environment.NewLine,
            LoopLimit = 1_000_000
        };

        ScriptObject objects = new()
        {
            { "Model", model }
        };

        context.PushGlobal(objects);
        context.PushGlobal(new Functions());

        string result = template.Render(context);
        writer.Write(result);
    }

    private TemplateModel GetTemplateModel(ExportOptions options, List<ExerciseRecord> exercises)
    {
        return new TemplateModel()
        {
            AllExercises = exercises,
        };
    }

    public Template LoadTemplate(ExportOptions options)
    {
        string path = Path.Combine(
            Environment.CurrentDirectory,
            $"{options.TemplateName}.template");

        FileInfo templateFile = new FileInfo(path);
        if (!templateFile.Exists)
        {
            throw new Exception($"Template not found: {path}");
        }

        string templateContent = File.ReadAllText(templateFile.FullName);
        Template template = Template.Parse(templateContent);
        return template;
    }
}
