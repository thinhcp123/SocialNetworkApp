FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/SocialNetworkApp/SocialNetworkApp.csproj", "src/SocialNetworkApp/"]
RUN dotnet restore "src/SocialNetworkApp/SocialNetworkApp.csproj"
COPY . .
WORKDIR "/src/src/SocialNetworkApp"
RUN dotnet build "SocialNetworkApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SocialNetworkApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SocialNetworkApp.dll"]
