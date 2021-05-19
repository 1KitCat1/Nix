using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Order
    {
        public List<Product> ProductList;
        public Shop Shop;
        public Courier Courier;
        public float Price;
        public float Commision;

        public Order(List<Product> productList, Shop shop, Courier courier)
        {
            Courier = courier;
            Shop = shop;
            ProductList = productList;
        }
    }
}
