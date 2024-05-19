public class Scripture
{
    private Reference _reference;
    private List<Word> _words; 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

        List<Word> visibleWords = _words.Where(word => !word.isHidden()).ToList();
        while (wordsHidden < numberToHide && visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            wordsHidden++;
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }
    
    public bool IsCompletelyHidden()
    {
        return false;
    }
}