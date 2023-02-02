using System;

class Program
{
    static void Main(string[] args)
    {

        int menuChoice = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            "   1: Start breathing activity",
            "   2: Start reflecting activity",
            "   3: Start listing activity",
            "   4: Quit"
        };

        while (menuChoice != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            menuChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (menuChoice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();

                    break;

                case 2:
                    ReflectionActivity refelectionActivity = new ReflectionActivity();
                    refelectionActivity.RunActivity();

                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();

                    break;

            }
        }
    }
}