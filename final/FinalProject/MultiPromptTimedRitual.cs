class MultiPromtTimedRitual : Ritual
{
    List<string> prompts = new List<string>();
    int time;

    public MultiPromtTimedRitual()
    {
        Console.WriteLine("How long in seconds will this ritual last?");
        time = int.Parse(Console.ReadLine());

        Menus.DisplayMenu();

        int userInput = int.Parse(Console.ReadLine());

        while (userInput != 2)
        {
            Console.WriteLine("What is the prompt?");
            string userPrompt = Console.ReadLine();
            prompts.Add(userPrompt);

            Menus.DisplayMenu();
            userInput = int.Parse(Console.ReadLine());
        }
    }


    public override void Prompt()
    {
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(1000 * time);
        }
    }
}