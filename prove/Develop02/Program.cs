using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string choice = GetMenuChoice();

        Journal journal = new Journal();

        while (choice != "5")
        {
            switch (choice)
            {
                case "1":
                    Entry entry = CreateEntry();
                    journal._entries.Add(entry);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    journal = LoadJournal();
                    break;
                case "4":
                    SaveJournal(journal);
                    break;

            }
            choice = GetMenuChoice();
        }
    }

    static string GetMenuChoice()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine();
        Console.WriteLine("1: New Entry");
        Console.WriteLine("2: Display Journal");
        Console.WriteLine("3: Load Journal");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
        Console.Write("Please enter a value: ");

        string menuChoice = Console.ReadLine();

        return menuChoice;
    }

    static Entry CreateEntry()
    {
        List<string> prompts = new List<string>();

        //I added a lot of prompts to choose from 
        prompts.Add("What is one word that describes today? Why?");
        prompts.Add("What are 1 thing you're grateful for and why?");
        prompts.Add("How was your day today? What went well, and what could have gone better?");
        prompts.Add("What is one word that describes today? Why?");
        prompts.Add("What goals are you working towards right now and do you need to make adjustments?");
        prompts.Add("What gives your life meaning right now?");
        prompts.Add("What are you worrying about right now and what can you do to return to the present?");
        prompts.Add("What are 3 good things that happened today?");
        prompts.Add("Who are you at your core?");
        prompts.Add("Share your testimony of Christ");

        Random dayPrompt = new Random();
        int randomPrompt = dayPrompt.Next(prompts.Count);

        string prompt = prompts[randomPrompt];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        DateTime date = DateTime.Today;

        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._response = response;
        entry._date = date;

        return entry;
    }

    static void DisplayJournal(Journal journal)
    {
        //iterate through journal and print each entry
        foreach (Entry entry in journal._entries)
        {
            Console.WriteLine($"{entry._date.ToShortDateString()}- {entry._prompt}- {entry._response}");
        }
    }

    static Journal LoadJournal()
    {
        Console.WriteLine("The name of the file you would like to load:");
        string fileName = Console.ReadLine();


        Journal journal = new Journal();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            Entry entry = new Entry();
            entry._date = DateTime.Parse(parts[0]);
            entry._prompt = parts[1];
            entry._response = parts[2];

            journal._entries.Add(entry);
        }

        return journal;
    }

    static void SaveJournal(Journal journal)
    {
        Console.WriteLine("The name of the file you would like to save to:");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in journal._entries)
            {
                outputFile.WriteLine($"{entry._date}- Prompt: {entry._prompt}- {entry._response}");
            }
        }
    }
}