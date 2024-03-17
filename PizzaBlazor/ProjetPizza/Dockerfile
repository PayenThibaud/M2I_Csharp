# Stage 1: Build the Blazor WebAssembly app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-blazor
WORKDIR /src
COPY ["ProjetPizza.csproj", "ProjetPizza/"]
RUN dotnet restore "ProjetPizza/ProjetPizza.csproj"
COPY . .
WORKDIR "/src/ProjetPizza"
RUN dotnet build "ProjetPizza.csproj" -c Release -o /app/build

# Stage 2: Publish the Blazor WebAssembly app
FROM build-blazor AS publish-blazor
RUN dotnet publish "ProjetPizza.csproj" -c Release -o /app/publish

# Stage 3: Build the ASP.NET Core API
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-api
WORKDIR /src
COPY ["ProjetPizza.csproj", "ProjetPizza/"]
RUN dotnet restore "ProjetPizza/ProjetPizza.csproj"
COPY . .
WORKDIR "/src/ProjetPizza"
RUN dotnet build "ProjetPizza.csproj" -c Release -o /app/build

# Stage 4: Publish the ASP.NET Core API
FROM build-api AS publish-api
RUN dotnet publish "ProjetPizza.csproj" -c Release -o /app/publish-api

# Stage 5: Final stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish-api /app/publish-api .
COPY --from=publish-blazor /app/publish ./wwwroot
ENTRYPOINT ["dotnet", "ProjetPizza.dll"]
