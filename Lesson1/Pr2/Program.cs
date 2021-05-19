using System;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Lesson1.Animal("dog");
            Console.WriteLine(animal.GetInfo());
            Console.Read();
        }
    }
}
