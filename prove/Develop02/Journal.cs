    public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry()
        {
            Prompt = prompt,
            Response = response,
            Date = date
        };
        entries.Add(entry);
    }

    public void DisplayEntries()

    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"Date: {entry.Date}");
                outputFile.WriteLine($"Prompt: {entry.Prompt}");
                outputFile.WriteLine($"Response: {entry.Response}");
                outputFile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();

        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string line;
            Entry entry = null;

            while ((line = inputFile.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    entry = new Entry();
                    entry.Date = line.Substring(6);
                    entry.Prompt = inputFile.ReadLine().Substring(8);
                    entry.Response = inputFile.ReadLine().Substring(10);
                    entries.Add(entry);
                    inputFile.ReadLine();
                }
            }
        }
    }
}