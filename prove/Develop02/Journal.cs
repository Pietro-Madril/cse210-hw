public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, append: false))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2]);
                    entry._date = parts[0];
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine($"Loading erro, the file doesn't exist.");
        }

    }
}