using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer");
        Word w = new Word(" ");
        Console.WriteLine(w.GetDisplayText());

        Reference reference = new Reference("3 Nephi", 11, 11);

        Scripture scripture = new Scripture(reference, "And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.");
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
            Console.Clear();
        }
        Console.WriteLine("Thank you for using Scripture Memorizer!");
    }
}