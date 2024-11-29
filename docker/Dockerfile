FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
<<<<<<< HEAD:docker/Dockerfile
COPY --from=build /app/out .
=======
COPY bin/Release/net8.0/publish/ App/
>>>>>>> 0651c99 (Finally it works):Dockerfile
ENTRYPOINT ["dotnet", "netrial.dll"]