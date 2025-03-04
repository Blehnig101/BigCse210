class Entry 
{
    public string _userEntry;
    public string _dateTime;
    public string _userPrompt;

    public void Display()
    {
        Console.WriteLine($"{_dateTime} {_userPrompt} {_userEntry}");
    }
}