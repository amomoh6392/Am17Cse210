using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // Added for exceeding requirements. I added a Level System to the Eternal Quest program
    public int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");

        // Added for exceeding requirements. this shows your level
        Console.WriteLine($"Current Level: {GetLevel()}");
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(int index)
    {
        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");

        //Added for exceeding requirements. this shows your level
        Console.WriteLine($"You are now Level {GetLevel()}!");
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

   public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]); 

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                SimpleGoal g = new SimpleGoal(name, desc, points);

                if (complete)
                {
                    g.RecordEvent();
                }

                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal g = new EternalGoal(name, desc, points);
                _goals.Add(g);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                int completed = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal g = new ChecklistGoal(name, desc, points, target, bonus);

                // restore progress
                for (int j = 0; j < completed; j++)
                {
                    g.RecordEvent();
                }

                _goals.Add(g);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}