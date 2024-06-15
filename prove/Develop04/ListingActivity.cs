using System; 
class ListingActivity : Activity 
{
    public ListingActivity(string name, string description) : base(name, description)
    {

    }
    public string ListingPromptGenerator()
    {
        Random rnd = new Random();

        string[] _listingPrompts = 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"

        };
        int index = rnd.Next(_listingPrompts.Length);
        return _listingPrompts[index]; 
    }
    public void ResponseList()
    {
        List<string> userInputList = new List<string>();
        string input;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write($">");
            input = Console.ReadLine();
            userInputList.Add(input);
            
        }
        int numberOfInputs = userInputList.Count;
        Console.WriteLine($"You listed {numberOfInputs} items!");
        Spinner(); 
    }   


    public void List()
    {
        StartingMessage();
        GetReady();
        Spinner();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{ListingPromptGenerator()}---");
        Console.Write("You may begin in: ");
        CountDownTimer();
        ResponseList();
        WellDone();
        Spinner();
        CompletedDuration();
    }
}