using System.IO;

public class Journal
{
    public Journal()
    {

    }

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        
    }

    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}~{entry._gratefulForText}~{entry._happyLevel}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] part = line.Split("~");

            entry._date = part[0];
            entry._promptText = part[1];
            entry._entryText = part[2];
            entry._gratefulForText = part[3];
            entry._happyLevel = part[4];
            _entries.Add(entry);
        }
    }
}