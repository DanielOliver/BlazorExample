FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

COPY . ./
WORKDIR /app/Blazor.Client
RUN dotnet publish -c Release

FROM nginx:alpine

WORKDIR /var/www/web
COPY --from=build-env /app/Blazor.Client/bin/Release/netstandard2.0/publish/Blazor.Client/dist .
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80
