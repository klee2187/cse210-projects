using System.IO;

class ScriptureFile
{
    private Dictionary<string, string> _scriptures = new Dictionary<string, string>();

    public void ReadFile()
    {
        string file = "scriptures.txt";
        string[] passages = System.IO.File.ReadAllLines(file);

        foreach (string passage in passages)
        {
            string[] lines = passage.Split(" - ");
            string reference = lines[0];
            string words = lines[1].Trim('"');

            _scriptures.Add(reference, words);
        }
    }

    public List<string> ScriptureList()
    {
        int wordCount = 0;

        List<string> display = new List<string>();

        foreach (KeyValuePair<string, string> passage in _scriptures)
        {
            string word = $"{wordCount + 1}. {passage.Key}";
            display.Add(word);
            wordCount ++;
        }

        return display;
    }

    public KeyValuePair<string, string> PickRandomScripture()
    {
        int scriptureLength = _scriptures.Count;

        Random random = new Random();
        int  index = random.Next(scriptureLength);

        KeyValuePair<string, string> randomScripture = _scriptures.ElementAt(index);
        return randomScripture;
    }
}