FROM mcr.microsoft.com/dotnet/sdk:5.0.203-alpine3.13-amd64 AS build

WORKDIR /src

COPY . .

RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release -o ./out

FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app
COPY --from=build /src/out .

EXPOSE 5000
ENTRYPOINT [ "dotnet", "Vulder.Api.dll" ]