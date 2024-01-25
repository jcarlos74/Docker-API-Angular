FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app


ENV ASPNETCORE_URLS=http://+:80

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["CidadesApi.csproj", "./"]
RUN dotnet restore "CidadesApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "CidadesApi.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "CidadesApi.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CidadesApi.dll"]
