using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        Console.WriteLine("Press enter to hide words, type quit to finish:");
        string userInput = ("");

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine("Press enter to hide words, type quit to finish:");

            Console.WriteLine(string.Format("{0} {1}", scriptureReference.ToString(), scriptureMemorizer.ToString()));
            Console.WriteLine();
            Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();

        }

    }
}

//string userAnswer = Console.ReadLine();
// string newScripture = "He is the light and the life of the world; yea, a light that is endless, that can never be darkened; yea, and also a life which is endless, that there can be no more death.";

// Console.WriteLine(newScripture);
// Console.WriteLine("Press enter to hide words, type quit to finish:");

// int numOfPresses = 0;

// while (userAnswer != "quit")
// {
//     Console.Clear();

//     Scripture scripture = new Scripture(newScripture, numOfPresses);
//     Console.WriteLine(scripture.GetText());


//     numOfPresses += 1;

//     Console.WriteLine("Press enter to hide words, type quit to finish:");
//     userAnswer = Console.ReadLine();
// }


