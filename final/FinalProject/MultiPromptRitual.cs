class MultiPromtRitual : Ritual
{
    List<string> prompts = new List<string>();

    public MultiPromtRitual()
    {
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
        Console.WriteLine("Press enter after each prompt to read the next one:");
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Console.ReadLine();
        }
    }
}