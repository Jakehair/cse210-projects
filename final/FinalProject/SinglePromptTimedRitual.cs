class SinglePromptTimedRitual : Ritual
{
    string customPrompt;
    int time;

    public SinglePromptTimedRitual()
    {
        Console.WriteLine("How long in seconds will this ritual last?");
        time = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the prompt?");
        customPrompt = Console.ReadLine();
    }

    public override void Prompt()
    {
        Console.WriteLine(customPrompt);
        Thread.Sleep(1000 * time);
    }
}