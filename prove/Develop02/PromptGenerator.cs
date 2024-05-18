public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "Who did you spend time with today?",
        "What is something you learned today?",
        "What scriptures you studied today?",
        "How your scripture study change your day?"
    };


    public string GetRandomPrompt()
    {
       if (_prompts.Count == 0)
        {
           return "No prompts available";
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        return _prompts[index];
    }

}