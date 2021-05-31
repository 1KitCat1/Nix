using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    abstract class Vehicle
    {
        public string ID { get; }
        public bool isRented { get; protected set; }
        public string Condition { get; protected set; }
        private string type;
        
        /*public Vehicle {}*/


    }
}
