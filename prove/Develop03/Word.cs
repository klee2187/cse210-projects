class Word
{
    private string _word;
    private bool _hiddenWord;

    public Word(string word)
    {
        _word = word;
        _hiddenWord = false;
    }

    public bool GetHiddenWord()
    {
       return _hiddenWord;
    }

    public void SetHiddenWord()
    {
        _hiddenWord = true;
    }

    public string HiddenPlaceholder()
    {
        string placeholder = "";

        if (_hiddenWord)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                placeholder += "_";
            }

            return placeholder;
        }
        else
        {
            return _word;
        }
    }
}