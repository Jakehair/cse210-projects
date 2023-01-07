using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        double total = numbers.Sum();
        double average = total / (numbers.Count - 1);
        double largest = numbers.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}