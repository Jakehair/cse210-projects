using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int square = SquareNumber(favNum);
        DisplayResult(name, square.ToString());
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int numToSquare)
    {
        int squaredNum = numToSquare * numToSquare;
        return squaredNum;
    }

    static void DisplayResult(string name, string num)
    {
        Console.WriteLine($"{name}, The square of your number is: {num}");
    }
}