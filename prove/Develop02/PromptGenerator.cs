public class PromptGenerator
{
    public static string GeneratePrompt()
    {
        Random rnd = new Random();

        string[] randomPrompts = 
        {
            "Who was the most interesting person I interacted with today?",
            "Tell me what you did to help another person today?",
            "How did you take care of yourself today?", 
            "Tell me three things that were positive parts of your day?",
            "What was something you wanted to do today, but weren't able to?", 
            "What are you going to do different tomorrow to be a better person?",
            "If you could do today over again, what would you do differently?", 
            "How can you eat better tomorrow than you did today?"

        };
        int index = rnd.Next(randomPrompts.Length);
        return randomPrompts[index];
    }
}