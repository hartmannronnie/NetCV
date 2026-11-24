
# ==========================================
# Stage 1: Build
# ==========================================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Gesamte Solution kopieren
COPY . .

# Blazor-Projekt wiederherstellen
RUN dotnet restore NetCV/NetCV.csproj

# Anwendung veröffentlichen
RUN dotnet publish NetCV/NetCV.csproj \
    -c Release \
    -o /app/publish \
    --no-restore


# ==========================================
# Stage 2: Runtime
# ==========================================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=10000

EXPOSE 10000

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "NetCV.dll"]
