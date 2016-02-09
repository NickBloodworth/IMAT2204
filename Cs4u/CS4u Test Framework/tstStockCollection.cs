﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace CS4u_Test_Framework
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to create
            clsStockCollection AllStock=new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void AllStockOK()
        {
            //create an instance of the class
            clsStockCollection StockItems = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStockItem> TestList = new List<clsStockItem>();
            //add an item to the list
            //create the item of test data
            clsStockItem TestItem = new clsStockItem();
            //set its properties
            TestItem.Active = true;
            TestItem.StockCode = "1";
            TestItem.StockName = "Windows";
            TestItem.ItemPrice = "38.00";
            TestItem.StockItemDescription = "Windows 12, completely rubbish";
            TestItem.SupplierName = "Microsoft";
            TestItem.StockLevel = "34";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            StockItems.AllStock = TestList;
            //test to see that the tow calues are the sam
            Assert.AreEqual(StockItems.AllStock, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //test to see that the two values are  the same
            Assert.AreEqual(AllStock.Count, SomeCount);

        }
        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsStockCollection StockItems = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs ot be a list of objects
            List<clsStockItem> TestList = new List<clsStockItem>();
            //add an item to the list
            //create the item of test data
            clsStockItem TestItem = new clsStockItem();
            //set its properties
            TestItem.StockCode = "1";
            TestItem.StockName = "Windows 2010";
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            StockItems.AllStock = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(StockItems.Count, TestList.Count);
        }

        
    }
        
        }



