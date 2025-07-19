// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    // Constructor that initializes the scripture with a reference and text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
       Random _random = new Random();
        for (int n = 0; n < numberToHide; n++)
        {
            var visibleIndices = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden())
                    visibleIndices.Add(i);
            }
            if (visibleIndices.Count > 0)
            {
                int index = visibleIndices[_random.Next(visibleIndices.Count)];
                _words[index].Hide();
            }
            else
            {
                break;
            }
        }
    }
    public string GetDisplayText()
    {
       string verse = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {verse}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}