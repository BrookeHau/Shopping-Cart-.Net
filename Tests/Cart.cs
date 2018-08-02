using System;
using System.Collections.Generic;

namespace Tests
{
    internal class Cart
    {
        private List<SuperMarketItem> items = new List<SuperMarketItem>();
        internal void addItemToCart(SuperMarketItem item)
        {
            items.Add(item);
        }

        internal int cartSize()
        {
            return items.Count;
        }
    }
}