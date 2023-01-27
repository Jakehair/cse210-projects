using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "Math Fractions");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jake Hair", "Decimals", "section 5.5", "problems 1-22");

        Console.WriteLine(mathAssignment.GetSummary() + mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jonny Jones", "War", "Causes of WWII");
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}