using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        do
        {
            Console.Write("Try to guess the magic number: ")
            int guess = Console.ReadLine();

            if (guess > number);
                Console.WriteLine("lower")
            else if(guess < number)
            Console.WriteLine("higher")

        } while (guess != number);
        Console.WriteLine("Congrats! You guessed the magic number! ")
    
}
}