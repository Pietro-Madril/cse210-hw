using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // //User defined guess loop - turn off the comments deleting the "//" in the lines 9 to 11 and add "//" in lines 13 and 14
        // Console.WriteLine("What is the secret number?");
        // string yourNumber = Console.ReadLine();
        // int Number = int.Parse(yourNumber);
        
        Random randomNumber = new Random();
        int Number = randomNumber.Next(1, 20);

        int guess = -1;
        while (guess != Number)    
        {   
            Console.WriteLine("What is your guess?");
            string yourGuess = Console.ReadLine();
            guess = int.Parse(yourGuess);
            if ( guess > Number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < Number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Your guess are correct");
            }
        }
    }
}