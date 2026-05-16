using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What made me smile today?");
        _prompts.Add("What goal did I work on today?");
        _prompts.Add("What am I looking forward to tomorrow?");
        _prompts.Add("What act of kindness did I witness today?");
        _prompts.Add("What am I looking forward to tomorrow?");
        _prompts.Add("What did I do today that brought me closer to my goals?");
        _prompts.Add("What was the funniest thing that happened today?");
        _prompts.Add("What was the most peaceful moment of my day?");
        _prompts.Add("What inspired me today?");
        _prompts.Add("What did I learn about myself today?");
        _prompts.Add("What accomplishment, big or small, did I achieve today?");
        _prompts.Add("What distracted me the most today?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

}