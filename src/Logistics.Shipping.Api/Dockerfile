#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Logistics.Shipping/Logistics.Shipping.Api.csproj", "Logistics.Shipping.Api/"]
RUN dotnet restore "Logistics.Shipping/Logistics.Shipping.Api.csproj"
COPY . .
WORKDIR "/src/Logistics.Shipping"
RUN dotnet build "Logistics.Shipping.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Logistics.Shipping.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Logistics.Shipping.Api.dll"]