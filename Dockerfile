FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY bin/Release/net8.0/publish/ App/
ENTRYPOINT ["dotnet", "netrial.dll"]