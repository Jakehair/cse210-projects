using System.Diagnostics;

class Activity
{
    private int duration;
    private string description;
    private string activityName;

    public Activity(string _description, string _activityName)
    {
        description = _description;
        activityName = _activityName;
    }

    public void SetDuration(int _duration)
    {
        duration = _duration;
    }

    public int GetDuration()
    {
        return duration;
    }

    public void SetDescription(string _description)
    {
        description = _description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetActivityName(string _activityName)
    {
        activityName = _activityName;
    }

    public string GetActivityName()
    {
        return activityName;
    }

    public void StartOfActivity()
    {
        Console.WriteLine(string.Format("Welcome to the {0}", activityName));
        Console.WriteLine();

        //figure this out --            not printing           ^^^^^^^^^^^    

        Console.WriteLine(string.Format("{0}", description));

        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like your session to last? ");
        duration = int.Parse(Console.ReadLine());
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!!!");
        DisplaySpinner(3);

        Console.WriteLine();
        Console.WriteLine(String.Format("You completed another {0} seconds of {1}", duration, activityName));
        DisplaySpinner(3);
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        int spinnerCounter = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            spinnerCounter++;

            switch (spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }


    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
    }

    public void CountDown(int timeInSeconds)
    {
        int countIndex = timeInSeconds;
        for (int i = timeInSeconds; i > 0; i--)
        {
            Console.Write(countIndex);
            Thread.Sleep(1000);

            Console.Write("\b \b");
            countIndex -= 1;
        }
    }
}