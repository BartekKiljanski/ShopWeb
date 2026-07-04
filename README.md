# ShopWeb / KiljanFlix

Prosty sklep internetowy napisany w ASP.NET Core MVC. Projekt powstał głównie do nauki warstwowej aplikacji webowej, pracy z bazą danych i automatyzacji testów UI.

Aplikacja działa jak mały sklep z filmami: jest panel klienta, koszyk, składanie zamówienia oraz panel administracyjny do zarządzania produktami, kategoriami, firmami i użytkownikami.

## Co jest w projekcie

- ASP.NET Core MVC / Razor Pages
- Entity Framework Core i migracje Code First
- SQL Server
- ASP.NET Identity
- Repository Pattern + Unit of Work
- Stripe jako przykład integracji płatności
- SendGrid jako przykład wysyłki maili
- podstawowy seed danych po starcie aplikacji

Testy automatyczne do tej aplikacji są w osobnym repozytorium:

https://github.com/BartekKiljanski/SeleniumGameShopQA

## Struktura

```text
src/
  ShopWeb/             aplikacja MVC
  ShopWeb.DataAccess/  DbContext, migracje, repozytoria
  ShopWeb.Models/      modele i ViewModele
  ShopWeb.Utility/     klasy pomocnicze, np. Stripe/Email
```

## Uruchomienie lokalnie

Wymagania:

- .NET 8 SDK
- SQL Server albo LocalDB

Domyślny connection string jest w `src/ShopWeb/appsettings.json`:

```json
"DefaultConnection": "Server=(localdb)\\MojLocal;Database=ShopBook;Trusted_Connection=True;TrustServerCertificate=True"
```

Jeśli używasz innej instancji SQL Servera, najprościej zmienić connection string lokalnie albo nadpisać go zmienną środowiskową:

```bash
ConnectionStrings__DefaultConnection="Server=localhost;Database=ShopBook;Trusted_Connection=True;TrustServerCertificate=True"
```

Start aplikacji:

```bash
dotnet restore
dotnet run --project src/ShopWeb/ShopWeb.csproj
```

Po starcie aplikacja sama wykonuje inicjalizację bazy przez `DbInitializer`.

## Docker

Dodałem też prostą konfigurację Dockera, żeby łatwiej odpalić projekt bez lokalnego SQL Servera.

```bash
docker compose up --build
```

Po uruchomieniu:

- aplikacja: `http://localhost:8080`
- SQL Server: `localhost:14333`

W `docker-compose.yml` connection string jest przekazywany przez zmienną:

```yaml
ConnectionStrings__DefaultConnection
```

## Konfiguracja zewnętrzna

W repo nie trzymam prawdziwych sekretów. Klucze do Stripe, SendGrid i Facebook Login najlepiej ustawiać przez zmienne środowiskowe:

```bash
Stripe__SecretKey=""
Stripe__PublishableKey=""
SendGrid__SecretKey=""
Authentication__Facebook__AppId=""
Authentication__Facebook__AppSecret=""
```

Facebook Login włącza się tylko wtedy, gdy `AppId` i `AppSecret` są ustawione.

## Testy

Do testów UI używam repozytorium `SeleniumGameShopQA`. Najczęściej odpalam najpierw aplikację, a później testy Selenium/SpecFlow na działającym środowisku.

Przykład:

```bash
docker compose up --build
```

A potem w repo z testami:

```bash
dotnet test
```
