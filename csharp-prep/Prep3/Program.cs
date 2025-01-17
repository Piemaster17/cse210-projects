using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = 0;

        while (guess != magicNumber) 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Corrent! The magic number was {magicNumber}!");
            }
        }
    }
}