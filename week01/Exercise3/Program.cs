using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Get a random number from Computer
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;

        // Hints for guess
        do 
        {   Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);





    }
}