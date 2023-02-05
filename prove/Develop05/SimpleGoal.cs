class SimpleGoal : Goal
{
    bool completed = false;

    public SimpleGoal() : base()
    {

    }

    public SimpleGoal(string _name, string _description, int _points, bool _completed) : base(_name, _description, _points)
    {
        completed = _completed;
    }

    public static SimpleGoal Deserialize(string serialized)
    {
        string[] pieces = serialized.Split(",");
        string name = pieces[1];
        string description = pieces[2];
        int points = int.Parse(pieces[3]);
        bool completed = bool.Parse(pieces[4]);

        return new SimpleGoal(name, description, points, completed);
    }

    public override void MarkComplete()
    {
        completed = true;
    }

    public override string ToString()
    {
        string mark = " ";
        if (completed)
        {
            mark = "x";
        }

        return string.Format("[{0}] {1}", mark, description);
    }

    public override int GetPoints()
    {
        if (completed)
        {
            return points;
        }
        return 0;
    }

    public override string Serialize()
    {
        return string.Format("SimpleGoal,{0},{1},{2},{3}", name, description, points, completed);
    }
}