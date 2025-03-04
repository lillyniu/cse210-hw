public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "What are some challenges that you have overcome this month?",
        "Which goals are you struggling with but slowly achieving?",
        "Where in your life is progress happening?",
        "How is your service blessing others?",
        "Why are you blessed today more than you were yesterday?",
    };

    private List<string> items = new List<string>();
    public ListingActivity(string userName) : base("Listing Activity", "This activity will help you reflect on the good things in life by challenging you to list as many answers to the question as possible in the time given.", userName){}
    public void Run()
    {
        Start();
        Random rand = new Random();
        string prompt = listingPrompts[rand.Next(listingPrompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            elapsed += 2;
        }

        End();
    }
}