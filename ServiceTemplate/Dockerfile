FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["Directory.Packages.props", "Directory.Packages.props"]
COPY ["services/{{ServiceNameKebabCaseAndApi}}/src/{{ProjectName}}/nuget.config", "services/{{ServiceNameKebabCaseAndApi}}/src/{{ProjectName}}/"]
COPY ["services/{{ServiceNameKebabCaseAndApi}}/src/{{ProjectName}}/{{ProjectName}}.csproj", "services/{{ServiceNameKebabCaseAndApi}}/src/{{ProjectName}}/"]

RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet restore "services/{{ServiceNameKebabCaseAndApi}}/src/{{ProjectName}}/{{ProjectName}}.csproj"

COPY . .

WORKDIR "/src/services/{{ServiceNameKebabCaseAndApi}}/src/{{ProjectName}}"
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet build "{{ProjectName}}.csproj" -c Release -o /app/build

FROM build AS publish
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet publish "{{ProjectName}}.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "{{ProjectName}}.dll"]
