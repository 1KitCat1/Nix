using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Product
    {
        public string ProductID;
        public string Name;
        public float Price;
        public int Amount;
        public Product(string id, string name, float price)
        {
            ProductID = id;
            Name = name;
            Price = price;
        }
        public Product(string id, string name, float price, int amount) : this(id, name, price)
        {
            Amount = amount;
        }
        public void IncreaseAmount(int additional)
        {
            Amount += additional;
        }
        public bool DecreaseAmount(int amount)
        {
            if (amount > Amount) return false;
            Amount -= amount;
            return true;
        }
    }
}
