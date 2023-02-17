class RoutineManager
{
    List<Routine> routines = new List<Routine>();
    Routine defaultRoutine;

    public void Run()
    {
        int userChoice = 0;

        while (userChoice != 5)
        {
            Menus.DisplayMainMenu();
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    RunRoutine();
                    break;
                case 2:
                    routines.Add(CreateRoutine());
                    break;
                case 3:
                    DeleteRoutine();
                    break;
                case 4:
                    ChangeDefaultRoutine();
                    break;
            }
        }
    }

    private void ChangeDefaultRoutine()
    {
        Console.WriteLine("Which routine would you like to be your default?");

        defaultRoutine = GetRoutineFromUser();
    }

    public Routine CreateRoutine()
    {
        Routine routine = new Routine();

        Console.WriteLine("What will be the name of this routine?");
        routine.name = Console.ReadLine();

        int chosenType = 0;
        while (chosenType != 5)
        {
            Console.WriteLine($"What type of ritual would you like to add to your {routine.name} routine?");

            Menus.DisplayRitualTypes();

            chosenType = int.Parse(Console.ReadLine());

            Ritual ritual = null;
            switch (chosenType)
            {
                case 1:
                    ritual = new SinglePromptRitual();
                    break;
                case 2:
                    ritual = new MultiPromtRitual();
                    break;
                case 3:
                    ritual = new SinglePromptTimedRitual();
                    break;
                case 4:
                    ritual = new MultiPromtTimedRitual();
                    break;

            }
            if (ritual != null)
            {
                routine.rituals.Add(ritual);
            }
        }
        return routine;
    }



    private void RunRoutine()
    {
        Routine routine = defaultRoutine;
        if (routine == null)
        {
            routine = GetRoutineFromUser();
        }

        routine.Run();
    }

    private Routine GetRoutineFromUser()
    {
        Console.WriteLine("Which routine?");

        for (int i = 0; i < routines.Count(); i++)
        {

            Console.WriteLine($"{i + 1}: {routines[i].name}");
        }

        int chosenIndex = int.Parse(Console.ReadLine());
        Console.WriteLine(routines[chosenIndex - 1]);
        return routines[chosenIndex - 1];
    }


    private void DeleteRoutine()
    {
        Console.WriteLine("Which routine would you like to remove?");

        Routine userRoutine = GetRoutineFromUser();

        routines.Remove(userRoutine);
    }



}