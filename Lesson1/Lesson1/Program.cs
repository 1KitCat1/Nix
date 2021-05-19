using System;

namespace Lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
        
    }
    public class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public string GetInfo()
        {
            return $"Animal {Name}";
        }
    }
}
