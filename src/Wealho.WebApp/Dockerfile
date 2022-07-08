FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Wealho.WebApp.csproj .
RUN dotnet restore Wealho.WebApp.csproj
COPY . .
RUN dotnet build Wealho.WebApp.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish Wealho.WebApp.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf