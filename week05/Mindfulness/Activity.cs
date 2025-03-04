public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; 

    protected string _userName; 
    protected static int sessionCount = 0;

    public Activity(string name, string description, string userName)
    {
        _name = name;
        _description = description;
        _userName = userName;
    }

    public virtual void Start()
    {
        Console.WriteLine($"\nStarting {_name}..\n");
        Console.WriteLine(_description);
        Console.Write("How long will your session be (in seconds)? ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid duration (e.g 1, 15, 20): ");
        }

        Console.WriteLine("Get ready to begin..");
        ShowCountdown(3);
    }

    public virtual void End() 
    {
        sessionCount++;
        Console.WriteLine("Good job, "+ _userName +"! Well done.");
        ShowSpinner(3);
        Console.WriteLine($"You've completed {_name} for {_duration} second/s.");
        Console.WriteLine($"Total sessions completed: {sessionCount}.");
        ShowSpinner(3);

    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}.."); 
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    }
    protected void ShowSpinner(int seconds)
    {
        char[] spinner = {'/', '-', '\\', '|'};
        for (int i=0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % spinner.Length]}");
            Thread.Sleep(250);
        }

        Console.WriteLine();
    }
}