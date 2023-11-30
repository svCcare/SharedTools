# SharedTools

![NuGet](https://img.shields.io/nuget/v/SharedTools)
![NuGet](https://img.shields.io/nuget/dt/SharedTools)

# Opis

Paczka NuGet **SharedTools** zawiera prostą bibliotekę umożliwiającą łatwe odczytywanie tekstu z plików oraz kilka Extension Methods zawierających operacje pomocne w rozwiązywaniu zadań z Advent Of Code.

# Instalacja

Aby zainstalować paczkę NuGet, możesz skorzystać z konsoli zarządzania pakietami w Visual Studio:

```
dotnet add package SharedTools
```

# Wykorzystanie
> new FileReader(string path, ReadOption readOption)
### Opis
Odczytuje tekst z zasobu. Rezultat przypisuje do propercji.
### Parametry:
`string path` - ścieżka zasobu

`ReadOption readOption` - Sposób odczytu, do wyboru ReadOption.All oraz ReadOption.Lines. W przypadku nie podania, domyślnie obiera opcje `All`.

### Zwraca:
`void`

### Exceptions
https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-8.0

## Klasa ExtensionMethods
> IEnumerable<T>.WithIndex<T>()
### Opis
Przy użyciu forech'a obiekt opakowany jest w tuple z indeksem (T,i)
### Parametry:
brak
### Zwraca
`IEnumerable<(T item, int index)>`, oraz w przypadku iteracji obiekt (T,i)
### Exceptions
ArgumentNullException w przypadku kiedy wywołana na obiekcie `null`

> string.ReplaceWhitespace(string replacement)
### Opis
Zamienia w ciągu znaków wszystkie whitespace'y na podany ciąg znaków
### Parametry:
`string replacement` - definiuje na jaki ciąg znaków zmienić whitespace ;domyślna wartość `""`
### Zwraca
`string` oryginalny ciąg znaków z podmianą whitespace'ów
### Exceptions
ArgumentNullException w przypadku kiedy wywołana na obiekcie `null`
RegexMatchTimeoutException w przypadku gdy na dopasowanie przeznaczone zostanie za dużo czasu

> IList<T>.PopMax<T>()
### Opis
Zwraca max wartość kolekcji przy okazji usuwając ją.
### Parametry:
brak
### Zwraca
`T` element kolekcji o maksymalnej wartości
### Generyczność
Elementy listy muszą dziedziczyć po `struct` oraz implementować podane interfejsy: struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
### Exceptions
ArgumentException
ArgumentNullException w przypadku kiedy wywołana na obiekcie `null`

# Ostatnie zmiany 1.1.0
+Dodano do klasy ExtensionMethods metodę `IList<T>.PopMax<T>()`

+Dodano do klasy ExtensionMethods metodę `string.ReplaceWhitespace(string replacement)`

# Licencja
MIT
