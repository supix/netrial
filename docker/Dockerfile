FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "netrial.dll"]