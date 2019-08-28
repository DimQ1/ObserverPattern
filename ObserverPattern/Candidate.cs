using System;

namespace ObserverPattern
{
    public class Candidate
    {
        public string Name { get; set; }

        public void Notify(string opportunity)
        {
            Console.WriteLine($"{this.Name} has been notified about the new apportunity {opportunity}");
        }
    }
}