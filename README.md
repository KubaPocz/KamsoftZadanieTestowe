# Zadanie Testowe – Parser Danych (CSV / JSON)

Aplikacja REST API napisana w **.NET 10**, której zadaniem jest dekodowanie danych zapisanych w formacie **Base64** oraz ich parsowanie z plików **CSV** i **JSON**.

---

## 🛠️ Technologie i architektura

Projekt został zrealizowany z wykorzystaniem następujących technologii i wzorców projektowych:

- **.NET 10 Web API** – nowoczesny framework do tworzenia usług REST.
- **Factory Pattern** – wybór odpowiedniego parsera na podstawie wartości `DataFormat` przekazanej w żądaniu.
- **CsvHelper** – wydajne i bezpieczne przetwarzanie danych CSV.
- **System.Text.Json** – wbudowana biblioteka do obsługi danych JSON.
- **Obsługa UTF-8 BOM oraz sanitizacja danych** – automatyczne usuwanie znaku BOM (`\uFEFF`) oraz zbędnych białych znaków z ciągu Base64 przed jego dekodowaniem.

---

## 🚀 Uruchomienie aplikacji

### Wymagania

- Zainstalowany **.NET 10 SDK** (lub nowszy).

### Instalacja i uruchomienie

1. Sklonuj repozytorium:

```bash
git clone https://github.com/KubaPocz/KamsoftZadanieTestowe.git
```

2. Przejdź do katalogu projektu:

```bash
cd KamsoftZadanieTestowe
```

3. Uruchom aplikację:

```bash
dotnet run
```

4. Otwórz dokumentację API w przeglądarce:

```
https://localhost:7259/scalar
```

---

## 📄 Dokumentacja API

Projekt wykorzystuje **Scalar** do prezentacji dokumentacji API oraz testowania endpointów.

Po uruchomieniu aplikacji przejdź pod adres:

```
https://localhost:7259/scalar
```

---

## 📦 Obsługiwane formaty danych

Aplikacja obsługuje dane zakodowane w formacie **Base64** dla następujących typów:

- ✅ CSV
- ✅ JSON

Typ danych wybierany jest na podstawie pola `DataFormat` przekazanego w żądaniu.

---

## 🏗️ Architektura

Projekt został przygotowany zgodnie z zasadą rozdzielenia odpowiedzialności.

```
Controller
    │
    ▼
Factory
    │
    ▼
Parser (CSV / JSON)
    │
    ▼
Wynik parsowania
```

Dzięki zastosowaniu wzorca **Factory Pattern** dodanie kolejnych parserów (np. XML lub YAML) wymaga jedynie implementacji nowego parsera oraz jego rejestracji w fabryce, bez modyfikowania logiki kontrolera.
