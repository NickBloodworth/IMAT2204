using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace CS4u_Test_Framework
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an insnace of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to dsee if it exists
            Assert.IsNotNull(AnOrderLine);

        }
        [TestMethod]
        public void OrderNoOK()
        {
            //create an insnace of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //assign an orderNo property
            Int32 OrderNo = 123;
            //assign the data to the property
            AnOrderLine.OrderNo = OrderNo;
            //test to see if the to values are the same
            Assert.AreEqual(AnOrderLine.OrderNo, OrderNo);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an insnace of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean OK = false;
            //create some test data
            string ItemCode = "item 1";
            //invoke the method
            OK = AnOrderLine.Valid(ItemCode);
            Assert.IsTrue(OK);
        }
    }

}
