static class Menus
{
    static public void DisplayMainMenu()
    {
        List<string> menuOptions = new List<string>
        {
            "1: Run Routine",
            "2: Create Routine",
            "3: Delete Routine",
            "4: Default Routine",
            "5: Quit"
        };

        foreach (string option in menuOptions)
        {
            Console.WriteLine(option);
        }
    }

    static public void DisplayRitualTypes()
    {
        List<string> ritualTypes = new List<string>
        {
            "1: Single Prompt ritual",
            "2: Multi Prompt ritual",
            "3: Single Prompt ritual (timed)",
            "4: Multi Prompt ritual (timed)",
            "5: Done adding rituals"
        };

        foreach (string ritualType in ritualTypes)
        {
            Console.WriteLine(ritualType);
        }
    }

    static public void DisplayMenu()
    {
        List<string> menuOptions = new List<string>
        {
            "1: Add a prompt ",
            "2: Finished"
        };

        Console.WriteLine("Select an option:");
        foreach (string option in menuOptions)
        {
            Console.WriteLine(option);
        }
    }
}