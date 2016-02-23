using System;
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
        public void StockListOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStockItem> TestList = new List<clsStockItem>();
            //add an item to the list
            //create the item of test data
            clsStockItem TestItem = new clsStockItem();
            //set its properties
            TestItem.Active = true;
            TestItem.StockCode = 12;
            TestItem.StockName = "Windows";
            TestItem.ItemPrice = "38.00";
            TestItem.StockItemDescription = "Windows 12, completely rubbish";
            TestItem.SupplierName = "Microsoft";
            TestItem.StockLevel = "34";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the tow calues are the sam
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStockItemPropertyOK()
        {

            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStockItem TestStockItem = new clsStockItem();
            //set the porpertoies of the test object
            TestStockItem.Active = true;
            TestStockItem.StockCode = 1;
            
            TestStockItem.StockItemDescription = "Completely rubbish software";
            TestStockItem.StockLevel = "12";
            TestStockItem.StockName = "Microsoft Windows 10";
            TestStockItem.ItemPrice = "300";
            //assign the data to the property
            AllStock.ThisStockItem = TestStockItem;
            //test to see that the tow values are the same
            Assert.AreEqual(AllStock.ThisStockItem, TestStockItem);
        }
        [TestMethod]
        public void ListAndCountOK()
    {
            //create an instance of the class we want to create
        clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
        List<clsStockItem> TestList = new List<clsStockItem>();
            //add an item to the list
            //create the item of test data
        clsStockItem TestItem = new clsStockItem();
            //set its properties
        TestItem.Active = true;
        TestItem.StockCode = 1;
        TestItem.StockItemDescription = "Completely rubbish software";
        TestItem.StockLevel = "12";
        TestItem.StockName = "Microsoft Windows 10";
        TestItem.ItemPrice = "300";
            //add the item to the test list
        TestList.Add(TestItem);
            //assign the data to the property
        AllStock.StockList = TestList;
            //test to see that the two value are the same
        Assert.AreEqual(AllStock.Count, TestList.Count);
            
    }
        [TestMethod]
        public void TwoItemsPresent()
        {
            //create an instance of the class
            clsStockCollection StockItems = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(StockItems.Count, 2);

        }
    }
        
        }



