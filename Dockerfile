FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /src
COPY . .
#RUN dotnet publish -c Release -r linux-x64 --self-contained /p:PublishSingleFile=true -o /publish
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=0 /publish .
CMD ["./Forciner.Web"]
