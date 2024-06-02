using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        //initialize _name, _description, _duration
        _name = name;
        _description = description;
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
         Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Count down");
    }
}