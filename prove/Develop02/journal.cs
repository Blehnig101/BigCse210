class Journal
{
    public List<Entry> _savedEntries = new List<Entry>();

    public void NewJournalFromFile(string filename)
    {
        _savedEntries = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(filename);


        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string dateTime = parts[0];
            string prompt = parts[1];
            string entrySaved = parts[2];

            Entry e = new Entry();
            e._userPrompt = prompt;
            e._dateTime = dateTime;
            e._userEntry = entrySaved;
            _savedEntries.Add(e);


        }
    }


}

