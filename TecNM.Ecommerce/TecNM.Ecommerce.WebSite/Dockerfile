FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TecNM.Ecommerce.WebSite/TecNM.Ecommerce.WebSite.csproj", "TecNM.Ecommerce.WebSite/"]
RUN dotnet restore "TecNM.Ecommerce.WebSite/TecNM.Ecommerce.WebSite.csproj"
COPY . .
WORKDIR "/src/TecNM.Ecommerce.WebSite"
RUN dotnet build "TecNM.Ecommerce.WebSite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TecNM.Ecommerce.WebSite.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TecNM.Ecommerce.WebSite.dll"]
