class ChecklistGoal : Goal
{
    int numTimesRequired;
    int numTimesCompleted;
    int bonus;
    public ChecklistGoal() : base()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        numTimesRequired = int.Parse(Console.ReadLine());

        Console.Write("When this goal is complete, how many bonus points will it be worth? ");
        bonus = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal(string _name, string _description, int _points, int _numTimesRequired, int _numTimesCompleted, int _bonus) : base(_name, _description, _points)
    {
        numTimesRequired = _numTimesRequired;
        numTimesCompleted = _numTimesCompleted;
        bonus = _bonus;
    }

    public static ChecklistGoal Deserialize(string serialized)
    {
        string[] pieces = serialized.Split(",");
        string name = pieces[1];
        string description = pieces[2];
        int points = int.Parse(pieces[3]);
        int numTimesRequired = int.Parse(pieces[4]);
        int numTimesCompleted = int.Parse(pieces[5]);
        int bonus = int.Parse(pieces[6]);


        return new ChecklistGoal(name, description, points, numTimesRequired, numTimesCompleted, bonus);
    }

    public override int GetPoints()
    {
        if (numTimesCompleted >= numTimesRequired)
        {
            return points * numTimesCompleted + bonus;
        }
        return points * numTimesCompleted;
    }

    public override void MarkComplete()
    {
        numTimesCompleted++;
    }

    public override string Serialize()
    {
        return string.Format("ChecklistGoal,{0},{1},{2},{3},{4},{5}", name, description, points, numTimesRequired, numTimesCompleted, bonus);
    }

    public override string ToString()
    {
        string mark = " ";
        if (numTimesCompleted >= numTimesRequired)
        {
            mark = "x";
        }
        return string.Format("[{0}] {1} -- Currently completed ({2}/{3})", mark, description, numTimesCompleted, numTimesRequired);
    }
}