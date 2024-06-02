using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello to Mindfulness App!");
        var choice = "";
        do
        {
            Console.WriteLine("Menu options: ");
            Console.WriteLine("1 - Start breathing activity");
            Console.WriteLine("2 - Start reflecting activity");
            Console.WriteLine("3 - Start listening activity");
            Console.WriteLine("4 - Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye, see you later");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
        while (choice != "4");
    }
}