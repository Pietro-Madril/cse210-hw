using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to GoalTracker");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}