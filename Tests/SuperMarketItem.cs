using System;

namespace Tests
{
    internal class SuperMarketItem
    {
        private string name;
        private double price;
        private string category;


       public SuperMarketItem(string name, double price, string category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }
        internal string getName()
        {
            return name;
        }

        internal double getPrice()
        {
            return price;
        }

        internal string getCategory()
        {
            return category;
        }
    }
}