# Используем официальный образ .NET SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Копируем CSPROJ и восстанавливаем зависимости
COPY *.csproj ./
RUN dotnet restore

# Копируем остальные файлы и собираем
COPY . ./
RUN dotnet publish -c Release -o out

# Используем официальный образ ASP.NET Core для запуска
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .

# Открываем порт
EXPOSE 80

# Запускаем приложение
ENTRYPOINT ["dotnet", "GraphQLServer.dll"]
