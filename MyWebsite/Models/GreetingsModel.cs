using System;

namespace MyWebsite.Models
{
    public class GreetingsModel
    {
        public GreetingsModel(string name)
        {
            Name = name;
            Greetings = $"Hi {name}! How are you?";
            Now = DateTime.Now;
        }
        public DateTime Now { get; }

        public string Name { get; }
        
        public string Greetings { get; }
    }
}