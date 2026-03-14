
class Scripture
{
   private string _reference;
   private List<Word> _scripture = new List<Word>();

   public Scripture(string reference, string scripture)
    {
        _reference = reference;

        string[] words = scripture.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _scripture.Add(newWord);
        }

    }

    public bool AllHidden()
    {
        bool allHidden = true;

        foreach (Word word in _scripture)
        {
            if (!word.GetHiddenWord())
            {
                allHidden = false;
            }
        }

        return allHidden;
    }

    public void HideRandomWords()
    {
        int totalWords = _scripture.Count;
        Random random = new Random();
        int wordCount = 0;

        foreach (Word word in _scripture)
        {
            if (!word.GetHiddenWord())
            {
                wordCount++;
            }
        }

        if (wordCount >= 5)
        {
            int index = -1;
            Word word = null;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    index = random.Next(totalWords);
                    word = _scripture[index];
                } while (word.GetHiddenWord());
                {
                    word.SetHiddenWord();
                }
            }
        }
        else
        {
            foreach (Word word in _scripture)
            {
                if (!word.GetHiddenWord())
                {
                    word.SetHiddenWord();
                }
            }
        }
    }

    public void DisplayScripture()
    {
        List<string> words = new List<string>();

        foreach (Word word in _scripture)
        {
            string value = word.HiddenPlaceholder();
            words.Add(value);
        }

        string wholeScripture = string.Join(" ", words);
        
        string scripture = $"{_reference} {wholeScripture}"; 
        Console.WriteLine(scripture);
        
    }
}