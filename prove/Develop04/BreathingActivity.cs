public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < stopTime)
        {
            Console.WriteLine("Breath in");
            ShowCountDown(5);        
            Console.WriteLine("Breath out");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
        
    }
}