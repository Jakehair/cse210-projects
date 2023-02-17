class SinglePromptRitual : Ritual
{
    public string customPrompt;

    public SinglePromptRitual()
    {
        Console.WriteLine("What is the prompt?");
        customPrompt = Console.ReadLine();
    }
    public override void Prompt()
    {
        Console.WriteLine(customPrompt);

        Console.WriteLine("Press enter to continue:");
        Console.ReadLine();
    }

}