class Reference
{
    private string _bookTitle = "";
    private int _chapterNumber = 0;
    private int _fverseNumber = 0;
    private int _lverseNumber = 0;

    public Reference(string b, int c, int v)
    {
        _bookTitle = b;
        _chapterNumber = c;
        _fverseNumber = v;
    }      
    public Reference(string b, int c, int f, int l)
    {
        _bookTitle = b;
        _chapterNumber = c;
        _fverseNumber = f;
        _lverseNumber = l;
    }

    public string GetReference()
    {
        string r = "";
        r += _bookTitle;
        r += " " + _chapterNumber.ToString();
        r += ":" + _fverseNumber.ToString();
        if (_lverseNumber > 0)
        {
            r += "-" + _lverseNumber.ToString();
        }

        return r;
    }
}