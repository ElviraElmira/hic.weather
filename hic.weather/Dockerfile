FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["hic.weather/hic.weather.csproj", "hic.weather/"]
RUN dotnet restore "hic.weather/hic.weather.csproj"
COPY . .
WORKDIR "/src/hic.weather"
RUN dotnet build "hic.weather.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "hic.weather.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "hic.weather.dll"]