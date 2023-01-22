<h1>Opisane wzorce projektowe:</h1>

<h2>Kompozyt:</h2>
Wzorzec kompozytu pozwala na budowanie hierarchii obiektów, gdzie każdy obiekt może być zarówno pojedynczym elementem, jak i złożonym z innych elementów. W .NET Core, wzorzec kompozytu może być zastosowany przy użyciu interfejsów lub klas abstrakcyjnych do określenia wspólnego interfejsu dla pojedynczych elementów i ich grup. Na przykład, aplikacja do zarządzania plikami może używać klasy abstrakcyjnej "Element" dla plików i folderów, a następnie używać tej samej klasy dla reprezentowania folderów zawierających pliki i foldery.

<h2>Obserwator: </h2>
Wzorzec obserwatora pozwala na rejestrowanie obiektów, które chcą być powiadamiane o zmianach w innym obiekcie. W .NET Core, można zastosować tę metodę za pomocą interfejsów lub klas abstrakcyjnych do określenia metod powiadamiania i rejestrowania obserwatorów. Na przykład, aplikacja do zarządzania zadaniami może rejestrować obiekty reprezentujące widoki, które chcą być powiadamiane o zmianach w zadaniach.

<h2>Strategia: </h2>
Wzorzec strategii pozwala na przechowywanie różnych algorytmów w osobnych klasach, co pozwala na łatwą zmianę algorytmu w zależności od potrzeb. W .NET Core, można zastosować tę metodę przy użyciu interfejsów lub klas abstrakcyjnych do określenia wspólnego interfejsu dla różnych algorytmów, a następnie przechowywać różne implementacje tego interfejsu w osobnych klasach. Na przykład, aplikacja do sortowania danych może używać interfejsu "SortStrategy" dla różnych algorytmów sortowania, takich jak sortowanie bąbelkowe, sortowanie przez wstawianie i sortowanie przez scalanie.

<h2>Metoda Wytwórcza: </h2>
Wzorzec metody wytwórczej pozwala na tworzenie obiektów bez konieczności określania konkretnej klasy obiektu. W .NET Core, można zastosować tę metodę przy użyciu interfejsów lub klas abstrakcyjnych do określenia wspólnego interfejsu dla różnych klas wytwórczych, a następnie przechowywać różne implementacje tego interfejsu w osobnych klasach. Na przykład, aplikacja do tworzenia dokumentów może używać interfejsu "DocumentFactory" do tworzenia różnych rodzajów dokumentów, takich jak pliki PDF, pliki Word i pliki Excel.

<h2>Dekorator: </h2>
Wzorzec dekoratora pozwala na dodawanie nowych funkcjonalności do istniejącego obiektu bez zmiany jego kodu. W .NET Core, można zastosować tę metodę przy użyciu interfejsów lub klas abstrakcyjnych do określenia wspólnego interfejsu dla różnych dekoratorów i istniejącego obiektu, a następnie tworzyć różne klasy dekoratorów, które rozszerzają funkcjonalność istniejącego obiektu. Na przykład, aplikacja do edycji tekstu może używać klasy "TextEditorDecorator" do dodawania nowych funkcjonalności, takich jak kolorowanie składni i automatyczne uzupełnianie, do istniejącego obiektu edytora tekstu bez konieczności modyfikowania jego kodu.
