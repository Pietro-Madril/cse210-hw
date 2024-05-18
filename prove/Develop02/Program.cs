using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal");
        Journal journal = new Journal();
        string choice = "";
        do
        {
            Console.WriteLine("Please, select one of the choices below");
            Console.WriteLine("1 - Write");
            Console.WriteLine("2 - Display");
            Console.WriteLine("3 - Load");
            Console.WriteLine("4 - Save");
            Console.WriteLine("5 - Quit");
            Console.Write("Please, enter the digit of your choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt(); 
                Console.WriteLine("Prompt: " + prompt);
                Console.Write("Your entry: ");
                string entryText = Console.ReadLine(); 
                Entry entry = new Entry(prompt, entryText); 
                journal.AddEntry(entry); 
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye, see you later");
            }
            else
            {
                Console.WriteLine("Invalid answer, please digit your choice again");  
            }
        }
        while (choice != "5");

    }
}