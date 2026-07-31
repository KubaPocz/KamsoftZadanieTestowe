# Zadanie Testowe – Parser Kontentu (CSV / JSON)

Aplikacja REST API napisana w **.NET 8**, służąca do dekodowania i parsowania danych wejściowych z formatu **Base64** w postaci plików **CSV** oraz **JSON**.

---

## 🛠️ Wykorzystane technologie i architektura

* **.NET 8 Web API**
* **Factory Pattern (Wzorzec Fabryki)** – elastyczne tworzenie odpowiedniego parsera na podstawie przekazanego typu w żądaniu (`DataFormat`).
* **CsvHelper** – bezpieczne i wydajne parsowanie danych CSV do słowników.
* **System.Text.Json** – wbudowany mechanizm parsowania danych JSON.
* **BOM & UTF-8 Sanitization** – automatyczne czyszczenie ciągu Base64 z ukrytych znaków nagłówka UTF-8 (`\uFEFF`) oraz białych znaków.

---

## 🚀 Jak uruchomić aplikację lokalnie

### Wymagania wstępne
* Zainstalowane SDK .NET 8.0 lub nowsze ([Pobierz .NET SDK](https://dotnet.microsoft.com/download))

### Krok po kroku

1. **Sklonuj repozytorium:**
   ```bash
   git clone <LINK_DO_TWOJEGO_REPOZYTORIUM>
   cd <NAZWA_KATALOGU_Z_PROJEKTEM>
