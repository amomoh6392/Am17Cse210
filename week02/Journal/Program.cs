using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Please select an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                
                //creativity adding a Short Entry Mode by letting the user choose between:
                //Full journal entry and a
                //Quick one-sentence entry
                Console.WriteLine($"What Entry Mode Do You Want");
                Console.WriteLine("1. Full journal entry");
                Console.WriteLine("2. Quick one-sentence entry");

                Console.Write("\nselection: ");
                int entryType = int.Parse(Console.ReadLine());

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                //this makes the user option valid and set it to a variable.
                string reply;
                if (entryType == 1)
                {
                    Console.WriteLine("Give a full response: ");
                    reply = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Give a short response: ");
                    reply = Console.ReadLine();
                }
                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, prompt, reply);
                journal.AddEntry(newEntry);
                Console.WriteLine("Your Entry Has Been Added.");
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal has been saved.");
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal is loaded.");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thanks for coming by, Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}