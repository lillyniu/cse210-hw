public class BreathingActivity : Activity
{
    public BreathingActivity(string userName) : base("Breathing Activity", "This activity will help you relax by walking you through a breathing exercise.", userName){}

    public void Run()
    {
        Start();
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.WriteLine("Take a deep breath in..");
            ShowCountdown(3);
            elapsed += 3;

            if (elapsed >= _duration)
            break;

            Console.WriteLine("Breathe out..\n");
            ShowCountdown(3);
            elapsed += 3;
        }

        End();
    }


}