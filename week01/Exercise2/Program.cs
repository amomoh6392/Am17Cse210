using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is the grade percent? ");
        string grade = Console.ReadLine();
        int score = int.Parse(grade);
        string letter;
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int lastdight = score % 10;
        string sign = "";
        if (lastdight >= 7)
        {
            sign = "+";
        }
        else if (lastdight <= 3)
        {
            sign = "-";
        }
        Console.WriteLine($"you have earned the grade {letter} {sign}");
        
        if (score >= 70)
            Console.WriteLine("congratulations you have passed the course");
        else 
            Console.WriteLine("sorry retake the course");
    }
}