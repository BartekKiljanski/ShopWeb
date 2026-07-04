FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ShopWeb.sln ./
COPY src/ShopWeb/ShopWeb.csproj src/ShopWeb/
COPY src/ShopWeb.DataAccess/ShopWeb.DataAccess.csproj src/ShopWeb.DataAccess/
COPY src/ShopWeb.Models/ShopWeb.Models.csproj src/ShopWeb.Models/
COPY src/ShopWeb.Utility/ShopWeb.Utility.csproj src/ShopWeb.Utility/

RUN dotnet restore ShopWeb.sln

COPY . .
RUN dotnet publish src/ShopWeb/ShopWeb.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080

COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "ShopWeb.dll"]
