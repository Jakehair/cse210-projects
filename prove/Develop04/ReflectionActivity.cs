class ReflectionActivity : Activity
{
    private List<string> prompts, questions;

    public ReflectionActivity() : base("This activity will help you reflect on times in your life when you showed resiliance. This will help you realize the power you have and how you can use it in other aspects of your life", "Reflection Activity")
    {

        prompts = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "Why do you think this experience came to mind? ",
            "What is one principle you learned from this experience? ",
            "How did it feel when you finished? ",
            "What made this successful? ",
            "What is your favorite part about this experience? ",
            "What did you learn about yourself from this experience?",
            ""
        };
    }

    public void RunActivity()
    {
        StartOfActivity();
        DisplayGetReady();
        DisplaySpinner(5);

        DisplayPrompt();

        CountDown(3);

        Console.Clear();
        DisplayQuestions();

        EndActivity();

        Console.WriteLine();

        DisplaySpinner(3);

    }

    private void DisplayPrompt()
    {
        Console.Clear();

        Console.WriteLine("Consider the following: ");

        int randomIndex = new Random().Next(0, prompts.Count());
        Console.WriteLine(prompts[randomIndex]);

        Console.WriteLine("When you have something in mind, press the enter key to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to your chosen experience: ");

    }

    public void DisplayQuestions()
    {
        List<int> indexes = new List<int>();

        Random randomIndexGenerator = new Random();
        for (int i = 0; i < 4; i++)
        {
            int randomInt = randomIndexGenerator.Next(0, questions.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = randomIndexGenerator.Next(0, questions.Count());
            }
            indexes.Add(randomInt);

            Console.WriteLine(questions[randomInt]);
            DisplaySpinner(GetDuration() / 4);
            Console.WriteLine();
        }
    }
}