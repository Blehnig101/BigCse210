
class Word
{
    private bool _replaceWord = false;
    private string _targetWord = "";

    public Word(string word)
    {
        _targetWord = word; 
    }

    public string GetWord()
    {
        return _targetWord;
    }

    public void HiddenWord()
    {
        _replaceWord = true;
        _targetWord = "___";
    }
    public bool IsHidden()
    {
        return _replaceWord;
    }
}