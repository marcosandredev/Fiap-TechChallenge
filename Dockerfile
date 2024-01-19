FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "CBF.API.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:7.0  AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 as build
WORKDIR /src
COPY ["CBF.API/CBF.API.csproj", "CBF.API/"]
COPY ["CBF.Domain/CBF.Domain.csproj", "CBF.Domain/"]
COPY ["CBF.Service/CBF.Service.csproj", "CBF.Service/"]
COPY ["CBF.Infra/CBF.Infra.csproj", "CBF.Infra/"]
RUN dotnet restore "CBF.API/CBF.API.csproj"
COPY . .
WORKDIR "/src/CBF.API"
RUN dotnet build "CBF.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CBF.API.csproj" -c Release -o /app/publish 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CBF.API.dll"]