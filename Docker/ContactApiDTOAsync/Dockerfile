FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ContactApiDTOAsync.csproj","."]
RUN dotnet restore "ContactApiDTOAsync.csproj"
COPY . .

RUN dotnet build "ContactApiDTOAsync.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContactApiDTOAsync.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","ContactApiDTOAsync.dll"]