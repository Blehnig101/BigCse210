using System.Runtime.CompilerServices;

class Scripture
{

    private Reference _startScrip;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _startScrip = reference;
        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public string GetScripture()
    {
        string s = "";
        s += _startScrip.GetReference();
        s += "\n\n";
        foreach(Word word in _words)
        {
            s += " " + word.GetWord();
        }
        return s;
    }
    public void HideEverything()
    {
        foreach(Word word in _words)
        {
            word.HiddenWord();
        }
    }

    public bool IsEvertthing()
    {
        bool isEverthing = true;
        foreach(Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                isEverthing = false;
            }
            
        }

        return isEverthing;

    }

    public void HideWord()
    {
        int hiddenWords = 0;
        while(hiddenWords != 2)
        {
            Random random = new Random();

            if (IsEvertthing() == true)
            {
                break;
            }

            int hideWord = random.Next(_words.Count);

            if (_words[hideWord].IsHidden() == false)
            {
                _words[hideWord].HiddenWord();



                hiddenWords ++;

            }
        }

    }
}