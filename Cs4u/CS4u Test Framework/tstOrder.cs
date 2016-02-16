using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS4U;

namespace CS4u_Test_Framework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create variable to hold CustomerID
            int CustID = 123;
            //assign CustID to AnOrder.CustomerID
            AnOrder.CustomerID = CustID;
            //check that both variables are the same
            Assert.AreEqual (AnOrder.CustomerID, CustID);
        }
        [TestMethod]
        public void ItemDescOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create variable to hold ItemDesc
            string ItemDesc = "Test data";
            //assign ItemDesc to AnOrder.ItemDesc
            AnOrder.ItemDesc = ItemDesc;
            //check that both variables are the same
            Assert.AreEqual(AnOrder.ItemDesc, ItemDesc);
        }
        [TestMethod]
        public void Valid()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create boolean value
            Boolean OK = false;
            //create variable to hold CustomerID
            int CustID = 123;
            //invoke the method
            OK = AnOrder.Valid(CustID);
            //check that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a date
            DateTime date = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.Date = date;
            //test to see if the values are the same
            Assert.AreEqual(AnOrder.Date, date);
        }
        [TestMethod]
        public void OrderItemPriceOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create a price
            double price = 22.22;
            //assign the data to the property
            AnOrder.Price = price;
            //test to see if the values are the same
            Assert.AreEqual(AnOrder.Price, price);
        }




    }
}
