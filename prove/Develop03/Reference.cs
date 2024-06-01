using System.ComponentModel.DataAnnotations;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startingVerse;
    private int? _endingVerse = null;
    public Reference(string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }
    public Reference(string book, int chapter, int startingVerse)
    {
        _book = book;
        _chapter = chapter;
        _startingVerse = startingVerse;
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_startingVerse}{(_endingVerse.HasValue ? $"-{_endingVerse}" : "")}";

    }
}










// **Reference Class:**
//   - **Attributes:**
//     - `Book`: Stores the book name.
//     - `Chapter`: Stores the chapter number.
//     - `StartVerse`: Stores the starting verse number.
//     - `EndVerse`: Stores the ending verse number (nullable).
//   - **Methods:**
//     - `Reference(string book, int chapter, int startVerse, int? endVerse = null)`: Initializes the reference with the given book, chapter, start verse, and optional end verse.
//     - `ToString()`: Returns a string representation of the reference, formatted appropriately for single or multiple verses.