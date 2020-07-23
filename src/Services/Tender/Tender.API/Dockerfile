#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Services/Tender/Tender.API/Tender.API.csproj", "Services/Tender/Tender.API/"]
RUN dotnet restore "Services/Tender/Tender.API/Tender.API.csproj"
COPY . .
WORKDIR "/src/Services/Tender/Tender.API"
RUN dotnet build "Tender.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tender.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tender.API.dll"]