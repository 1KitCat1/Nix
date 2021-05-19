using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Car
    {
        public string ID { get; protected set; }
        public string Mark { get; protected set; }
        public int HorsePower { get; protected set; }
        public int Year { get; protected set; }
        public int Price { get; protected set; }
        public bool IsActive { get; set; }
        public string Class { get; protected set; }
        public string Model { get; protected set; }

        public Car(string ID, string mark, string model, string _class, int horsePower, int year, int price)
        {
            this.ID = ID;
            Mark = mark;
            HorsePower = horsePower;
            Year = year;
            Price = price;
            IsActive = true;
            Model = model;
            Class = _class;
        }
        public string Info()
        {
            if (!IsActive) return "Lot has already been sold";
            return $"Car | ID:{ID} | Mark: {Mark} | HP: {HorsePower} | Year: {Year} | Price: {Price}";
        }
        public bool Disactivate()
        {
            if (IsActive)
            {
                IsActive = false;
                return !IsActive;
            }
            return false;
        }
        public bool Reactivate()
        {
            if (IsActive)
            {
                IsActive = false;
                return !IsActive;
            }
            return false;
        }

    }
}
