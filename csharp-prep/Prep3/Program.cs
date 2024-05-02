using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random random = new Random();

        int magicNumber = random.Next(1,20);

        int guess = 0;

        int tracker = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            tracker++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Congratualations! You guessed the magic number! ");

                Console.WriteLine($"It took you {tracker} tries to guess the magic number! ");            
            }            

        }

    }
}