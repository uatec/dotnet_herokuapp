
FROM microsoft/dotnet:1.0.0-preview2-sdk

RUN mkdir -p /dotnetapp
COPY . /dotnetapp
WORKDIR /dotnetapp/src


RUN dotnet restore
RUN dotnet publish
CMD dotnet run