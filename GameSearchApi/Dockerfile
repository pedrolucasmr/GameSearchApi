FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GameSearchApi/GameSearchApi.csproj", "GameSearchApi/"]
RUN dotnet restore "GameSearchApi/GameSearchApi.csproj"
COPY . .
WORKDIR "/src/GameSearchApi"
RUN dotnet build "GameSearchApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GameSearchApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GameSearchApi.dll"]
