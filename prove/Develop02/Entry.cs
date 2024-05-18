public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} : {_promptText}");
        Console.WriteLine($"{_entryText}");

    }
}