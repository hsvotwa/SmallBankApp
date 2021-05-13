FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SmallBankApp/Server/SmallBankApp.Server.csproj", "SmallBankApp/Server/"]
COPY ["SmallBankApp/Shared/SmallBankApp.Shared.csproj", "SmallBankApp/Shared/"]
COPY ["SmallBankApp/Client/SmallBankApp.Client.csproj", "SmallBankApp/Client/"]
RUN dotnet restore "SmallBankApp/Server/SmallBankApp.Server.csproj"
COPY . .
WORKDIR "/src/SmallBankApp/Server"
RUN dotnet build "SmallBankApp.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SmallBankApp.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmallBankApp.Server.dll"]