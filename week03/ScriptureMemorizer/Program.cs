using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        //creativity Having my program work with a library of scriptures rather than a single one
        List<Scripture> scriptures = new List<Scripture>();  
              
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life.");
        scriptures.Add(scripture1);

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(reference2,"Trust in the Lord with all thine heart and lean not unto thine own understanding");
        scriptures.Add(scripture2);

        Reference reference3 = new Reference("Psalm", 23, 1);
        Scripture scripture3 = new Scripture(reference3, "The Lord is my shepherd I shall not want");
        scriptures.Add(scripture3);
        
        //creativity Having my program Choose scriptures at random to present to the user.
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
        while (!selectedScripture.IsCompletelyHidden())
        {
            try
            {
                Console.Clear();
            }
            catch
            {
                
            }

            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine("Press Enter to Continue or to quit: ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(3);
        }
         try
        {
            Console.Clear();
        }
        catch
        {
            
        }
        Console.WriteLine(selectedScripture.GetDisplayText());
    }
}