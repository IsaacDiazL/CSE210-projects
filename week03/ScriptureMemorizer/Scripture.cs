// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        
    }    
    public void HideRandomWords(int numberToHide)
    {
        // Logic to hide a random number of words in the scripture text
    }
    public string GetDisplayText() {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        // Logic to check if all words are hidden
        return false;
    }
}