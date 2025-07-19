// Keeps track of a single word and whether it is shown or hidden.
public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially, the word is not hidden
    }
    public void Hide()
    {
        _isHidden = true; // Logic to hide the word
    }
    public void Show()
    {
        _isHidden = false; // Logic to show the word
    }
    public bool IsHidden()
    {
        return _isHidden; // Returns whether the word is hidden
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Return a placeholder for hidden words by nuumber of underscores
            return new string('_', _text.Length); // Replace with underscores
        }
        return _text; // Return the actual word if not hidden
    }
}