class Scripture
{
    private string scriptureText;
    private Reference scriptureReference;

    public Scripture(Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        scriptureText = _scriptureText;
    }

    public string toString()
    {
        return string.Format("{0}", scriptureText);
    }

}

// private List<Word> _words = new List<Word>();

// public Scripture(string scripture)
// {




// }

// public Scripture(string scripture, int numOfPresses)
// {
//     string[] words = scripture.Split(" ");
//     foreach (string word in words)
//     {
//         Word word1 = new Word(word);
//         _words.Add(word1);
//     }
// }


// public string GetText()
// {
//     List<string> stringWords = new List<string>();
//     foreach (Word word in _words)
//     {
//         stringWords.Add(word.GetText());
//     }
//     return string.Join(" ", stringWords);

// }

// public void HideWords()
// {
//     List<Word> visibleWords = new List<Word>();
//     foreach (Word word in _words)
//     {
//         if (word.IsVisible())
//         {
//             visibleWords.Add(word);
//         }

//     }

//     Random random = new Random();

//     for (int i = 0; i <= 3; i++)
//     {
//         int index = random.Next(_words.Count);
//         visibleWords[index].Hide(false);
//     }

//     // 1. Figure out what to hide
//     // 2. Hide each one
