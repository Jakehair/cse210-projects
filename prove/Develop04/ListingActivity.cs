class ListingActivity : Activity
{
    List<string> responses = new List<string>();

    List<string> prompts = new List<string>
    {
        "--- Who are people that you appreciate? ---",
        "--- What are personal strengths of yours? ---",
        "--- Who are people that you have helped this week? ---",
        "--- When have you felt the Holy Ghost this month? ---",
        "--- Who are some of your personal heroes? ---"
    };


    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain area of your life", "Listing Activity")
    {

    }

    public void RunActivity()
    {

        StartOfActivity();
        int duration = GetDuration();


        DisplayGetReady();
        DisplayPrompt();

        Console.WriteLine();

        DateTime startTime = DateTime.Now;

        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);

            currentTime = DateTime.Now;
        }

        Console.WriteLine(string.Format("You listed {0} items!", responses.Count()));

        EndActivity();
    }

    private void DisplayPrompt()
    {
        Console.Clear();

        Console.WriteLine("Consider the following prompt: ");

        int randomIndex = new Random().Next(0, prompts.Count());
        Console.WriteLine(prompts[randomIndex]);

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press the enter key to continue");
        Console.ReadLine();

        Console.WriteLine("Now think of some things that relate to the prompt: ");
        DisplaySpinner(5);

        Console.WriteLine("Now list as many as you can");
    }


    public string RandomPrompt()
    {
        throw new NotImplementedException();
    }

}