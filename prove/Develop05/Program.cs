using System;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();

        List<string> menuOptions = new List<string>
        {
            "   1. Create New Goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Quit"
        };

        void DisplayMenu()
        {

            Console.WriteLine(string.Format("You have {0} points.\n", CalculatePoints(goals)));
            Console.WriteLine("Menu options: ");
            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }
        }

        // Print menu to the terminal
        DisplayMenu();

        Console.Write("Select a choice from the menu: \n");
        int userMenuInputChoice = int.Parse(Console.ReadLine());

        while (userMenuInputChoice != 6)
        {
            switch (userMenuInputChoice)
            {
                case 1:
                    Goal newGoal = CreateGoal();
                    goals.Add(newGoal);
                    break;

                case 2:
                    DisplayGoals(goals);
                    break;

                case 3:
                    SaveGoals(goals);
                    break;

                case 4:
                    goals = LoadGoals();
                    break;

                case 5:
                    RecordEvent(goals);
                    break;

            }

            DisplayMenu();
            userMenuInputChoice = int.Parse(Console.ReadLine());
        }

    }



    private static int CalculatePoints(List<Goal> goals)
    {
        int points = 0;

        foreach (Goal goal in goals)
        {
            points += goal.GetPoints();
        }

        return points;
    }

    private static Goal CreateGoal()
    {
        List<string> menuOptions = new List<string>
        {
            "   1. Simple Goal",
            "   2. Eternal Goal",
            "   3. Checklist Goal"
        };

        foreach (string option in menuOptions)
        {
            Console.WriteLine(option);
        }

        Console.WriteLine("Which type of goal would you like to create?");
        int goalChoice = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case 1: return new SimpleGoal();
            case 2: return new EternalGoal();
            case 3:
            default: return new ChecklistGoal();
        };

    }
    private static void DisplayGoals(List<Goal> goals)
    {
        for (int i = 0; i < goals.Count(); i++)
        {
            Console.Write(string.Format("{0}. ", i + 1));
            Console.WriteLine(goals[i]);
        }
    }

    private static void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("Your goals: ");
        DisplayGoals(goals);
        Console.Write("Which goal have you completed? ");
        int goalNum = int.Parse(Console.ReadLine());
        goals[goalNum - 1].MarkComplete();
    }

    private static List<Goal> LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        List<Goal> goals = new List<Goal>();

        foreach (string line in lines)
        {
            if (line.StartsWith("SimpleGoal"))
            {
                goals.Add(SimpleGoal.Deserialize(line));
            }

            else if (line.StartsWith("EternalGoal"))
            {
                goals.Add(EternalGoal.Deserialize(line));
            }

            else if (line.StartsWith("ChecklistGoal"))
            {
                goals.Add(ChecklistGoal.Deserialize(line));
            }
        }
        return goals;
    }

    private static void SaveGoals(List<Goal> goals)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        List<string> lines = new List<string>();

        foreach (Goal goal in goals)
        {
            lines.Add(goal.Serialize());
        }

        System.IO.File.WriteAllLines(fileName, lines);
    }



}