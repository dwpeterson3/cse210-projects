class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide(Action onHideSuccess)
    {
        if (!_isHidden)
        {
            _isHidden = true;
            onHideSuccess();
        }
    }

    public string Render()
    {
        if (_isHidden == true)
        {
            return "___";
        }

        else
        {
            return _text;
        }
    }

}



//  **Word Class:**
//   - **Attributes:**
//     - `Text`: Stores the actual word.
//     - `IsHidden`: Indicates if the word is hidden.
//   - **Methods:**
//     - `Word(string text)`: Initializes the word with the given text and sets `IsHidden` to `false`.
//     - `Hide()`: Sets `IsHidden` to `true`.
//     - `Render()`: Returns "____" if the word is hidden, otherwise returns the word itself.