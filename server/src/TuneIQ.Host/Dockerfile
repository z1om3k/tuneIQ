FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TuneIQ.Host/TuneIQ.Host.csproj", "TuneIQ.Host/"]
COPY ["TuneIQ.API/TuneIQ.API.csproj", "TuneIQ.API/"]
COPY ["TuneIQ.Core/TuneIQ.Core.csproj", "TuneIQ.Core/"]
COPY ["TuneIQ.Data/TuneIQ.Data.csproj", "TuneIQ.Data/"]
COPY ["TuneIQ.Services/TuneIQ.Services.csproj", "TuneIQ.Services/"]
RUN dotnet restore "TuneIQ.Host/TuneIQ.Host.csproj"
COPY . .
WORKDIR "/src/TuneIQ.Host"
RUN dotnet build "TuneIQ.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TuneIQ.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TuneIQ.Host.dll"]
