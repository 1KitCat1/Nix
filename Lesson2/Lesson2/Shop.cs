using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Shop
    {
        public string ShopID { get; protected set; }
        public string Address { get; protected set; }
        public List<Product> Products;
        public Shop(string id, string address)
        {
            ShopID = id;
            Address = address;
        }
        public Shop(string id, string address, List<Product> products) : this(id, address)
        {
            Products = products;
        }
        public void AddProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }
        public bool DelProduct(string productID)
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if(Products[i].ProductID == productID)
                {
                    Products.Remove(Products[i]);
                    return true;
                }
            }
            return false;
        }
    }
}
