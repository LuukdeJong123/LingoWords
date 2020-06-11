FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["LingoWords.csproj", "./"]
COPY . .
RUN dotnet restore "./LingoWords.csproj"
WORKDIR "/src/."
RUN dotnet build "LingoWords.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LingoWords.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY "basiswoorden-gekeurd.txt" .
ENTRYPOINT ["dotnet", "LingoWords.dll"]