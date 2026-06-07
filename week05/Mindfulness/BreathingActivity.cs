using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            ShowBreathingAnimation("Breathe in...");
            ShowCountdown(4);
            elapsed += 4;

            if (elapsed >= _duration)
                break;

            ShowBreathingAnimation("Breathe out...");
            ShowCountdown(4);
            elapsed += 4;
        }

        DisplayEndingMessage();
    }
    //Added more meaningful animations for the breathing to exceed requirement
    public void ShowBreathingAnimation(string message)
    {
        Console.WriteLine($"\n{message}");

        string[] phases = { ".", "..", "...", "....", ".....", "......" };

        int delay = 150;

        for (int i = 0; i < phases.Length; i++)
        {
            Console.Write(phases[i] + "\r");
            Thread.Sleep(delay);
            delay += 80; // slows down breathing
        }

        Console.WriteLine();
    }
}