using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Writeline("What is your first name?");
        string first = Console.readline();

        Console.writeline("What is your last name? ");
        string last = Console.readline();

        Console.writeline($"Your name is {first} {last}. ");
    }
}