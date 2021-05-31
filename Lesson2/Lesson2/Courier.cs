using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Courier
    {
        public string ID { get; protected set; }
        public bool IsBusy { get; protected set; }
        public bool IsOnLine { get; protected set; }
        public string Position { get; protected set; }
        private float range;
        private string name;
        private float balance;
        
        

        public Courier(string id, string name)
        {
            ID = id;
            this.name = name;
        }
        public Courier(string id, string name, float balance) : this (id, name)
        {
            this.balance = balance;
        }
        public Courier(string id, string name, float balance, string position) : this ( id, name, balance)
        {
            Position = position;
        }
        
    }
}
