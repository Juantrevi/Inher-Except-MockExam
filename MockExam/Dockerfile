FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MockExam/MockExam.csproj", "MockExam/"]
RUN dotnet restore "MockExam/MockExam.csproj"
COPY . .
WORKDIR "/src/MockExam"
RUN dotnet build "MockExam.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MockExam.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MockExam.dll"]
