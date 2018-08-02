using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ItemTest
    {
        SuperMarketItem item; 

        [TestInitialize]
        public void testInIt()
        {
           item = new SuperMarketItem("banana", 1.5, "fruit");
        }

        //method naming: class name_method tested_expected value

        [TestMethod]        
        public void SuperMarketItem_GetName_NameValue()
        {           
           String itemName = item.getName();
            Assert.AreEqual("banana", itemName);
        }

        [TestMethod]
        public void SuperMarketItem_GetPrice_PriceValue()
        {            
            double itemPrice = item.getPrice();
            Assert.AreEqual(1.5, itemPrice);
        }

        [TestMethod]
        public void SuperMarketItem_getCategory_CategoryValue()
        {
            String itemCategory = item.getCategory();
            Assert.AreEqual("fruit", itemCategory);
        }


    }
}
