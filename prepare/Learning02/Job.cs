public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = -1;
    public int _endYear = -1;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_company} ({_jobTitle}) {_startYear} - {_endYear}");
    }
}