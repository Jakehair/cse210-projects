using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 900000999;
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(0, 101);

        while (guess != magicNum)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!!");
            }
        }
    }
}