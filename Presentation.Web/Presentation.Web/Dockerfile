#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Presentation.Web/Presentation.Web/Presentation.Web.csproj", "Presentation.Web/Presentation.Web/"]
RUN dotnet restore "Presentation.Web/Presentation.Web/Presentation.Web.csproj"
COPY . .
WORKDIR "/src/Presentation.Web/Presentation.Web"
RUN dotnet build "Presentation.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Presentation.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presentation.Web.dll"]