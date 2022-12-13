#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

RUN apt-get update && apt-get install -y libgdiplus

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LunaryCore/LunaryCore.csproj", "LunaryCore/"]
RUN dotnet restore "LunaryCore/LunaryCore.csproj"
COPY . .
WORKDIR "/src/LunaryCore"
RUN dotnet build "LunaryCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LunaryCore.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LunaryCore.dll"]

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet LunaryCore.dll