
class ScriptureMemorizer
{

    private Scripture scripture;
    private List<string> scriptureTextList;

    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        ConvertTextToList();
    }

    private void ConvertTextToList()
    {
        scriptureTextList = scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, scriptureTextList.Count());
            //Todo only replace word if it hasn't been replaced yet
            if (scriptureTextList[rndIndex].Contains('_') == false)
            {
                scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
            }

            scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
            wordsRemoved++;

        } while (wordsRemoved != numWordsToRemove);
    }

    public override string ToString()
    {
        return string.Join(' ', scriptureTextList);
    }


    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scriptureTextList)
        {
            if (word.Contains('_') == false) ;
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }

}




// private string _text;
// private bool _hidden = false;

// public Word(string word)
// {
//     _text = word;
// }

// public void Hide(bool hidden)
// {
//     if (hidden == true)
//     {
//         _hidden = hidden;
//     }
// }

// public string GetText()
// {

//     if (_hidden)
//     {
//         string hiddenValue = "";

//         string[] letters = _text.Split();
//         foreach (string letter in letters)
//         {
//             hiddenValue += "_";
//         }
//         return hiddenValue;
//     }
//     return _text;
// }

// public bool IsVisible()
// {
//     if (_hidden == false)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
