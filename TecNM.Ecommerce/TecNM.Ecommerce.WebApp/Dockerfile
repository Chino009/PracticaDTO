FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TecNM.Ecommerce.WebApp/TecNM.Ecommerce.WebApp.csproj", "TecNM.Ecommerce.WebApp/"]
RUN dotnet restore "TecNM.Ecommerce.WebApp/TecNM.Ecommerce.WebApp.csproj"
COPY . .
WORKDIR "/src/TecNM.Ecommerce.WebApp"
RUN dotnet build "TecNM.Ecommerce.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TecNM.Ecommerce.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TecNM.Ecommerce.WebApp.dll"]
