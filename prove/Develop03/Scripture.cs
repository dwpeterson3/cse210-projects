class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _hiddenWordCount;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words.Split(' ').Select(word => new Word(word)).ToList();
        _hiddenWordCount = 0;

    }
    public void Display()
    {
        Console.Clear();
        Console.Write(_reference + " ");
        Console.WriteLine(String.Join(" ", _words.Select(word => word.Render())));
        Console.WriteLine();

    }

    public void HideRandomWords()
    {
        int remainingWordCount = _words.Count - _hiddenWordCount;

        int requiredCount = remainingWordCount > 3 ? 3 : remainingWordCount;
        int hiddenCount = 0;
        Random rnd = new Random();

        while (hiddenCount < requiredCount)
        {
            int index = rnd.Next(_words.Count);
            _words[index].Hide(onHideSuccess: () => { hiddenCount++; _hiddenWordCount++; });
        }
    }

    public bool IsFullyHidden()
    {
        return _words.Count == _hiddenWordCount;
    }


}


// **Scripture Class:**
//   - **Attributes:**
//     - `Reference`: Stores the reference of the scripture using the `Reference` class.
//     - `Words`: Stores a list of `Word` objects representing each word in the scripture.
//   - **Methods:**
//     - `Scripture(Reference reference, string text)`: Initializes the scripture with the given reference and text, splits the text into words, and creates a list of `Word` objects.
//     - `Display()`: Clears the console and prints the reference and words, showing hidden words as "____".
//     - `HideRandomWords(int count)`: Randomly hides the specified number of words that are not already hidden.
//     - `IsFullyHidden()`: Checks if all words are hidden.