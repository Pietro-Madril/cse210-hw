using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Graphic Designer";
        job1._company = "Fronteira";
        job1._startYear = 2023;
        job1._endYear =  2024;
    
        Job job2 = new Job();
        job2._jobTitle = "Game Desinger";
        job2._company = "Frontier Studios";
        job2._startYear = 2023;
        job2._endYear =  2024;

        Resume myResume = new Resume();
        myResume._name = "Pietro Madril";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}