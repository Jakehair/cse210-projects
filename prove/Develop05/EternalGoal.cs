class EternalGoal : Goal
{
    int numTimesCompleted;
    public EternalGoal() : base()
    {

    }

    public EternalGoal(string _name, string _description, int _points, int numTimesCompleted) : base(_name, _description, _points)
    {

    }

    public static EternalGoal Deserialize(string serialized)
    {
        string[] pieces = serialized.Split(",");
        string name = pieces[1];
        string description = pieces[2];
        int points = int.Parse(pieces[3]);
        int numTimesCompleted = int.Parse(pieces[4]);

        return new EternalGoal(name, description, points, numTimesCompleted);
    }

    public override int GetPoints()
    {
        return points * numTimesCompleted;
    }

    public override void MarkComplete()
    {
        numTimesCompleted++;
    }

    public override string Serialize()
    {
        return string.Format("EternalGoal,{0},{1},{2},{3}", name, description, points, numTimesCompleted);
    }

    public override string ToString()
    {
        return string.Format("[ ] {0} -- {1} times completed", description, numTimesCompleted);
    }
}