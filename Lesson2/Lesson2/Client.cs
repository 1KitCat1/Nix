using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Client
    {
        public string ClientID { get; protected set; }
        public float Balance { get; protected set; }
        public string Name { get; protected set; }
        public string Address { get; protected set; }
        public List<Order> OrderList;
        public Client(string id, string address, string name)
        {
            ClientID = id;
            Address = address;
            Name = name;
            Balance = 0;
        }
    }
}
