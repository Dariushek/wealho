FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Wealho.Ui.csproj .
RUN dotnet restore Wealho.Ui.csproj
COPY . .
RUN dotnet build Wealho.Ui.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish Wealho.Ui.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf