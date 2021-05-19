using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var CarList = new List<Car>();
            CarList.Add(new Car("HR1223", "Honda", "Rapid", "Coupe", 154, 2007, 14560));
            CarList.Add(new Car("TL2805", "Toyota", "Land Cruiser", "SUV", 217, 2010, 25500));
            CarList.Add(new Car("LL9756", "Lexus", "LX", "SUV", 275, 2012, 29800));
            foreach(var car in CarList)
            {
                Console.WriteLine(car.Info());
            }
            CarList[1].Disactivate();
            Console.WriteLine("-------------");
            foreach (var car in CarList)
            {
                Console.WriteLine(car.Info());
            }
            Console.Read();
        }
    }
}
