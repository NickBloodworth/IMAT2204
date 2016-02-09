﻿using System;
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
        public void CompanyIDOK()
        {
            //create instance of class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create LineCost variable
            double lineCost = 10.99;
            //assign lineCost to AnOrderLine.LineCost
            AnOrderLine.LineCost = lineCost;
            //see if both variables are the same
            Assert.AreEqual(AnOrderLine.LineCost, lineCost);
        }
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
