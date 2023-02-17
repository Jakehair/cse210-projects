class BreathingActivity : Activity
{
    public BreathingActivity() : base("This activity will help you relax and focus by bringing your attention to your breath. Just breathe and believe.", "Breathing Activity")
    {

    }

    public void RunActivity()
    {
        StartOfActivity();
        int duration = GetDuration();

        DisplayGetReady();
        DisplaySpinner(4);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        int breathCount = 4;
        while (currentTime < futureTime)
        {

            switch (breathCount % 4)
            {
                case 0: Console.Write("Inhale..."); break;

                case 1: Console.Write("Hold..."); break;

                case 2: Console.Write("Exhale..."); break;

                case 3: Console.Write("Hold..."); break;
            }
            breathCount++;
            BoxBreath();

            currentTime = DateTime.Now;
        }
        Console.Clear();

        EndActivity();

    }

    public void BoxBreath()
    {
        CountDown(5);
        Console.WriteLine();

        // Console.Write("Inhale...");

        // Console.WriteLine();
        // Console.Write("Hold...");
        // CountDown();
        // Console.WriteLine();
        // Console.Write("Exhale...");
        // CountDown();
        // Console.WriteLine();
        // Console.Write("Hold...");
        // CountDown();
        // Console.WriteLine();

    }

}