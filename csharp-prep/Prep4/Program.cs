using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numberList = new List<int>();
        //Adding numbers to our list
        int yourNumber = -1;
        while (yourNumber != 0)
        {
            Console.WriteLine("Please, enter a number and enter 0 to quit: ");
            string yourAnswer = Console.ReadLine();
            yourNumber = int.Parse(yourAnswer);
            if (yourNumber != 0)
            {
                numberList.Add(yourNumber);
            }        
        }
        //Sum the values in our list
        int sum = 0;
        foreach (int number in numberList)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of our list is {sum}");

        //The average of our list
        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average of our list is {average}");

        //The largest/maximus number of our list
        int largest = numberList[0];
        foreach (int number in numberList)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest/maximus number of our list is {largest}");
    }
}