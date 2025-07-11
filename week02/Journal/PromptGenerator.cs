// Supplies random prompts whenever needed
public class PromptGenerator
{
    // Stores a list of prompts
    public List<string> _prompts = new List<string>();
    public string prompt1;
    public string prompt2;
    public string prompt3;
    public string prompt4;
    public string prompt5;
    // Constructor to initialize prompts
    public PromptGenerator()
    {
        prompt1 = "Who was the most interesting person I interacted with today?";
        prompt2 = "What was the best part of my day?";
        prompt3 = "How did I see the hand of the Lord in my life today?";
        prompt4 = "What was the strongest emotion I felt today?";
        prompt5 = "What Could I have done differently today?";
    }
    public string GetRandomPrompt()
    {
        _prompts.Add(prompt1);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt2);
        _prompts.Add(prompt5);
        Random j = new Random();
        int index = j.Next(_prompts.Count); // Get a random index
        string prompt = _prompts[index]; // Get the prompt at that index
        return prompt;
    }

}