using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment a1 = new Assignment("Pietro Madril", "English");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Ricardo Feliciano", "Fractions", "10.7", "7-11");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bruno Silva", "Brazillian History", "Why the Farroupilha Revolutions happaned");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}