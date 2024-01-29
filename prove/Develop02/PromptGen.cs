public class PromptGen 
{

    public List<string> prompt = new List<string>
        {
            "How did your day start off?",
            "What was the highlight of your morning?",
            "Did anything unexpected happen today?",
            "How did you handle any challenges that came your way?",
            "What's something that made you smile today?",
            "Any interesting conversations or interactions today?",
            "Did you learn something new today?",
            "What was the most satisfying part of your day?",
            "Any small victories or accomplishments to share?",
            "How did you unwind or relax after a busy day?",
            "Was there a moment that made you feel grateful today?",
            "Did you have any memorable meals or snacks?",
            "What's one thing you wish had gone differently today?",
            "Any exciting plans or events on the horizon?",
            "Did you connect with someone you haven't spoken to in a while?",
            "How did the weather impact your day?",
            "Any funny or amusing moments you'd like to share?",
            "Did you make progress on any personal goals today?",
            "What music, podcasts, or books accompanied your day?",
            "Did you spend time outdoors today?",
            "How did you prioritize self-care today?",
            "Any moments where you felt proud of yourself?",
            "Were there any opportunities for kindness or generosity?",
            "What was the most challenging part of your day?",
            "Did you encounter anything that inspired you?",
            "How did you manage stress or pressure today?",
            "Any interesting thoughts or reflections from the day?",
            "What's something you're looking forward to tomorrow?",
            "Did you capture any special moments with photos?",
            "How would you rate your overall mood today?",
        };


    public string RandomDisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompt.Count);
        return prompt[index];

    }
}