using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "Who is someone you are grateful for and why?",
        "What opportunity di you usee today that you thankful for?",
        "What is something in nature that you appreciate?",
        "What is a talent or ability you are grateful to have?"
    };

    public GratitudeActivity() : base("Gratitude Activity", "This activity will help you focus on the positive things in your life by expressing gratitude.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine("\nConsider the following gratitude prompt:");
        Console.WriteLine($"\n※※※※ {_prompts[random.Next(_prompts.Count)]} ※※※※");

        Console.Write("\nYou may begin in: ");
        ShowCountdown(5);

        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nEnter as many gratitude responses as you can:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou recorded {responses.Count} gratitude responses!");
        DisplayEndingMessage();
    }
}