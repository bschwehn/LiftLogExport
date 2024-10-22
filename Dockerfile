# Stage 1: Build and publish the .NET app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy just source code in - be sure to update the .dockerignore file if you add more files
COPY *.sln ./
COPY LiftLog.Backup.Tests ./LiftLog.Backup.Tests/
COPY LiftLog.Backup ./LiftLog.Backup/
COPY LiftLogCLI ./LiftLogCLI/
RUN dotnet restore

# Run tests
RUN dotnet test

# Publish the application
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Create runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/publish /app

# Set up working directory
WORKDIR /shellpwd

# Create symbolic link from /shellpwd/Templates to /app/Templates
RUN ln -s /app/Templates /Templates

# Set the entry point to the absolute path of LiftLogCLI
ENTRYPOINT ["/app/LiftLogCLI"]