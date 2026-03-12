class Word
{
    private string _word;
    private bool _hiddenWord;

    public Word(string word)
    {
        _word = word;
        _hiddenWord = false;
    }

    public void HideWord()
    {
        _hiddenWord = true;
    }

    public string GetHiddenWord()
    {
       
    }
}