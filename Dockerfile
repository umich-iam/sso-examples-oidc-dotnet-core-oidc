# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:6.0 as build-env
WORKDIR /dotnet-core-oidc
COPY dotnet-core-oidc/*.csproj .
RUN dotnet restore
COPY dotnet-core-oidc .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /publish
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "dotnet-core-oidc.dll"]