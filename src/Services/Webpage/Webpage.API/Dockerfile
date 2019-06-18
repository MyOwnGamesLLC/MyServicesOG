FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Services/Webpage/Webpage.API/Webpage.API/Webpage.API.csproj", "src/Services/Webpage/Webpage.API/Webpage.API/"]
RUN dotnet restore "src/Services/Webpage/Webpage.API/Webpage.API/Webpage.API.csproj"
COPY . .
WORKDIR "/src/src/Services/Webpage/Webpage.API/Webpage.API"
RUN dotnet build "Webpage.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Webpage.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Webpage.API.dll"]