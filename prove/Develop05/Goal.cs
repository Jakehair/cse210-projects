abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;


    protected Goal()
    {
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();

        Console.Write("What is a brief description of your goal? ");
        description = Console.ReadLine();

        Console.Write("How many points are associated with this goal? ");
        points = int.Parse(Console.ReadLine());

    }
    protected Goal(string _name, string _description, int _points)
    {
        name = _name;
        description = _description;
        points = _points;
    }

    public abstract int GetPoints();

    public abstract void MarkComplete();

    public abstract string Serialize();

}