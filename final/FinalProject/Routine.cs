class Routine
{
    public string name;

    public List<Ritual> rituals = new List<Ritual>();

    public void Run()
    {
        foreach (Ritual ritual in rituals)
        {
            Console.WriteLine("Here is your next ritual:");
            ritual.Prompt();
        }
    }
}