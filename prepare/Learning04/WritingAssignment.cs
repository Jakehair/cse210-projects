class WritingAssignment : Assignment
{
    string _title;
    string _topic;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
        _topic = topic;
    }

    public string GetWritingInformation()
    {
        return ($"{_studentName} {_title} {_topic}");
    }

}