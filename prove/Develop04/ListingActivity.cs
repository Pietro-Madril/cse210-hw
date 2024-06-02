public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime stopTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Start listing items. Press Enter after each item. Press Enter on an empty line to finish early.");

        while (DateTime.Now < stopTime)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                break;
            }
            items.Add(item);
        }

        return items;
    }
}
