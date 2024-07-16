FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80
EXPOSE 81

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ProfessorOfTheYear/ProfessorOfTheYear/ProfessorOfTheYear.csproj", "ProfessorOfTheYear/ProfessorOfTheYear/"]
COPY ["ProfessorOfTheYear/ProfessorOfTheYear.Client/ProfessorOfTheYear.Client.csproj", "ProfessorOfTheYear/ProfessorOfTheYear.Client/"]
RUN dotnet restore "ProfessorOfTheYear/ProfessorOfTheYear/ProfessorOfTheYear.csproj"
COPY . .
WORKDIR "/src/ProfessorOfTheYear/ProfessorOfTheYear"
RUN dotnet build "ProfessorOfTheYear.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "ProfessorOfTheYear.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProfessorOfTheYear.dll"]
