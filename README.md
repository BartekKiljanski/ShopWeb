Aplikacja "KiljanFlix" oparta jest na modelu MVC (Model-View-Controller), korzystając z ASP.NET Core jako frameworku do budowy responsywnego i skalowalnego interfejsu użytkownika. Wykorzystanie architektury N-Tier oraz wzorca repozytorium umożliwia modularną konstrukcję aplikacji, co ułatwia zarządzanie kodem oraz rozszerzanie systemu o nowe funkcjonalności.
Główne cechy systemu obejmują:
•	Zarządzanie kategoriami i produktami: Administracja kategoriami i produktami pozwala na skuteczne organizowanie katalogu filmów.
•	Zarządzanie firmami: Funkcjonalność ta umożliwia dodawanie, edycję oraz usuwanie firm, co jest istotne dla zarządzania partnerami biznesowymi.
•	Zarządzanie kontami użytkowników: System umożliwia tworzenie, edycję oraz usuwanie kont użytkowników, zapewniając elastyczne zarządzanie dostępem do aplikacji.
•	Bezpieczeństwo i autentykacja: Integracja z ASP.NET Identity gwarantuje silne mechanizmy autentykacji i autoryzacji, w tym logowanie za pomocą emaila i hasła, a także poprzez konta Google i Facebook.
•	Obsługa zamówień: Użytkownicy mogą przeglądać filmy, dodawać je do koszyka i dokonywać płatności za pomocą Stripe, co stanowi kompleksowe rozwiązanie e-commerce.
•	Komunikacja z użytkownikami: System oferuje funkcjonalności takie jak powiadomienia email, umożliwiając efektywną komunikację z klientami.
Projekt wykorzystuje różnorodne narzędzia i technologie, potwierdzając swoją aktualność i zaawansowanie:
•	Entity Framework: Do operacji na bazie danych z wykorzystaniem migracji "code first".
•	Identity Framework: Do zaawansowanego zarządzania użytkownikami i ich autentykacji.
•	Stripe: Dla obsługi płatności online.
•	Integracja z usługami Google i Facebook: Dla alternatywnych metod logowania.
•	Sesje w ASP.NET Core: Do zarządzania stanem użytkownika.
•	TempData i View Components: Dla zaawansowanej interakcji z użytkownikiem.
•	Data Seeding i wdrażanie do Azure: Do inicjalizacji danych i hostingu aplikacji w chmurze.
