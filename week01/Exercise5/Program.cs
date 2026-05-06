using System;
using System.ComponentModel;

class Program
{
        static void Main(string[] args)
        {
            DisplayMessage();
            string name = PromptUserName();

            int number = PromptUserNumber();
            int result = SquareNumber(number);

            DisplayResult(result, name);

        }

        static void DisplayMessage()
        {
            Console.WriteLine("welcome to the program");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string username = Console.ReadLine();
            return username;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int usernumber = int.Parse(Console.ReadLine());
            return usernumber;
        }
        static int SquareNumber(int usernumber)
        {
            return usernumber * usernumber;
        }
        static void DisplayResult(int result, string username)
        {
            Console.WriteLine($"Brother {username}, the square of your number is {result}");
        }
}