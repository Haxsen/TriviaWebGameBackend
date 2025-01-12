# Stage 1: Build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory in the container
WORKDIR /app

COPY . ./
RUN dotnet restore

# Publish the app to the /out directory
RUN dotnet publish HaxsenTriviaServer/HaxsenTriviaServer.csproj -c Release -o /out

# Stage 2: Set up the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory in the container
WORKDIR /app

# Copy the published app from the build stage
COPY --from=build /out .

# Expose the port the app will run on
EXPOSE 8080

# Define the entry point to run the app
ENTRYPOINT ["dotnet", "HaxsenTriviaServer.dll"]
