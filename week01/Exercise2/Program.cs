using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What percentage did you get? ");
        string valueFromUser = Console.ReadLine();
        
        int x = int.Parse(valueFromUser);

        if (x > 90)
        {
            Console.WriteLine("You got an A. ");
        }
        else if (x > 80)
        {
            Console.WriteLine("You got an B. ");
        }
        else if (x > 70)
        {
            Console.WriteLine("You got an C. ");
        }
        else if (x > 60)
        {
            Console.WriteLine("You got an D. ");
        }  
        else if (x < 60)
        {
            Console.WriteLine("You got an F. ");
        }
    }
}