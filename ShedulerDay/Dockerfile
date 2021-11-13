FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ShedulerDay/ShedulerDay.csproj", "ShedulerDay/"]
RUN dotnet restore "ShedulerDay/ShedulerDay.csproj"
COPY . .
WORKDIR "/src/ShedulerDay"
RUN dotnet build "ShedulerDay.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShedulerDay.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShedulerDay.dll"]
