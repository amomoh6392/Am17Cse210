using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice = 0;

        Console.WriteLine("Welcome to the Eternal Quest Program!");

        while (choice != 6)
        {
            Console.WriteLine();
            manager.DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                CreateGoal(manager);
            }
            else if (choice == 2)
            {
                manager.ListGoals();
                Pause();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                manager.SaveGoals(filename);
                Pause();
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                manager.LoadGoals(filename);
                Pause();
            }
            else if (choice == 5)
            {
                manager.ListGoals();

                Console.Write("Which goal did you complete? ");
                int index = int.Parse(Console.ReadLine());

                manager.RecordGoal(index - 1);
                Pause();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thank you For your time! Keep progressing on your goals!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
                Pause();
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select goal type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            manager.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("Target completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}