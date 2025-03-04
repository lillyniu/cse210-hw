public class ReflectionActivity : Activity
{
    private List<string> reflectionPrompts = new List<string>
    {
        "Think of a time when you did the right thing but stood alone",
        "Think of a time when you finished a challenging task.",
        "Think of a time you put someone else's needs before your own.",
        "Think of a time when you followed a prompting."
    };

    private List<string> reflectionQuestions = new List<string>
    {
        "Why was this moment empowering?",
        "How did you get better as a person?",
        "What were some things that were trying to hold you back?",
        "What helped lead you to this decision?",
        "How much stronger did you feel?",
        "What is something you wish you did sooner about this?",
        "What did you learn about yourself going through this?",
        "What could you learn from this experience that can help someone else?",
        "How can you improve what didn't go as planned?"
    };

    public ReflectionActivity(string userName) : base("Reflection Activity", "This experience will help you reflect on moments in oyur life that empowered you. I hope you find the pre-existing strength from within during this reflection.", userName){}

    public void Run()
    {
        Start();
        Random rand = new Random();
        string prompt = reflectionPrompts[rand.Next(reflectionPrompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            string _question = reflectionQuestions[rand.Next(reflectionQuestions.Count)];
            Console.WriteLine(_question);
            ShowSpinner(5);
            elapsed += 5;
        }

        End();
    }
}