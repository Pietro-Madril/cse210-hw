using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int score = int.Parse(grade);

        string letterScore = "";
        if (score >= 90)
            {
                letterScore = "A";
            }
        else if (score >= 80)
            {
                letterScore = "B";
            }
        else if (score >= 70)
            {
                letterScore = "C";
            }
        else if (score >= 60)
            {
                letterScore = "D";
            }
        else
            {
                letterScore = "F";
            }

        Console.WriteLine($"Your grade is {letterScore}");
        if (score >= 70)
            {
                Console.WriteLine("Congratulations, you passed");
            }
        else
            {
                Console.WriteLine("Your grade aren`t enought, see you next year");
            }
    }
}