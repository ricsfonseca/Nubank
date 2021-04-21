FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

COPY . .

RUN dotnet restore

RUN dotnet publish -c release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /publish

COPY --from=build /publish .

ENTRYPOINT ["dotnet", "Nubank.Api.dll"]
