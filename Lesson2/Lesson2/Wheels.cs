using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Wheels
    {
        public string ID { get; protected set; }
        public int Diameter { get; protected set; }
        public string Type { get; protected set; }
        public int Amount { get; protected set; }
        public Wheels(string id, int diameter, string type, int amount)
        {
            ID = id;
            Diameter = diameter;
            Type = type;
            Amount = amount;
        }
    }
}
