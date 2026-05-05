using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        
        string keep_playing = "yes";
        
        while (keep_playing == "yes")
        {
            int secret_number = randomGenerator.Next(1, 100);
            int guess_count = 0;
            int guess = -1;

            while (guess != secret_number)
            {
                Console.Write("what is your guess? ");
                string input = Console.ReadLine();
                guess= int.Parse(input);
                guess_count++;
                if (guess > secret_number)
                {
                    Console.WriteLine("guess lower");
                }
                else if (guess < secret_number)
                {
                    Console.WriteLine("guess higher");
                }
                else
                {
                    Console.WriteLine("you guessed it");
                    Console.WriteLine($"It took you {guess_count} guesses.");
                }
            }
            Console.Write("Do you want to continue? ");
            keep_playing = Console.ReadLine().ToLower();
        }

    }
}