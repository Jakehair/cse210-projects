using System;

class Program
{
    static void Main(string[] args)
    {
        string userGrade;
        string sign = "";
        Console.WriteLine("What is your grade percentage?");
        string stringUserGradePercent = Console.ReadLine();
        int userGradePercent = int.Parse(stringUserGradePercent);

        if (userGradePercent >= 90)
        {
            userGrade = ("A");
        }

        else if (userGradePercent >= 80)
        {
            userGrade = ("B");
        }

        else if (userGradePercent >= 70)
        {
            userGrade = ("C");
        }

        else if (userGradePercent >= 60)
        {
            userGrade = ("D");
        }

        else
        {
            userGrade = ("F");
        }

        int getSign = (userGradePercent % 10);

        if (getSign <= 3 && userGrade != "F")
        {
            sign = "-";
        }
        else if (getSign >= 7 && userGrade != "A" && userGrade != "F")
        {
            sign = "+";
        }

        Console.WriteLine($"Your letter grade is {userGrade}{sign}");

        if (userGradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!! Keep up the good work!");
        }

        else
        {
            Console.WriteLine("Never give up!");
        }



    }
}