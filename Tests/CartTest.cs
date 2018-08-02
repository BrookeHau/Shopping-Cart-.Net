using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CartTest
    {
        //method naming: class name_method tested_expected value

        SuperMarketItem item;
        SuperMarketItem item2;
        
        [TestInitialize]
        public void testInIt()
        {
            item = new SuperMarketItem("banana", 1.5, "fruit");
            item2 = new SuperMarketItem("bread", 5.5, "bakery");
        }

        [TestMethod]
        public void Cart_cartSize_returnTwoAsSize()
        {
            Cart cart = new Cart();
            cart.addItemToCart(item);
            cart.addItemToCart(item2);
            int cartSize = cart.cartSize();
            Assert.AreEqual(2, cartSize);

        }


        [TestMethod]
        public void Cart_cartSize_returnOneAsSize()
        {
            Cart cart = new Cart();
            cart.addItemToCart(item);
            
            int cartSize = cart.cartSize();
            Assert.AreEqual(1, cartSize);

        }
    }
}
