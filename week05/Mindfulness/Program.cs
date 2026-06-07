using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        bool running = true;

        while (running)
        {
            try
            {
                Console.Clear();
            }
            catch
            {
            }

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            // Exceeding Requirements:
            // Added a Gratitude Activity as a fourth activity.
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                // Added a Gratitude Activity as a fourth activity.
                // This activity helps users focus on positive experiences
                // and count gratitude responses entered during the session.
                case "4":
                    new GratitudeActivity().Run();
                    break;

                case "5":
                    running = false;
                    break;
            }
           

            if (running)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}