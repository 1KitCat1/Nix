using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Courier
    {
        public string ID { get; protected set; }
        public bool IsBusy { get; protected set; }
        private string Name;
        private float Balance;

        public Courier(string id, string name)
        {
            ID = id;
            Name = name;
        }
        public Courier(string id, string name, float balance) : this (id, name)
        {
            Balance = balance;
        }
        
    }
}
