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
            //TestItem.Active = true;
            TestItem.StockNo = 12;
            TestItem.StockName = "Windows";
            TestItem.ItemPrice = 38;
            TestItem.StockItemDescription = "Windows 12, completely rubbish";
            TestItem.SupplierName = "Microsoft";
            TestItem.StockLevel =34;
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
            Int32 SomeCount = 3;
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
            //TestStockItem.Active = true;
            TestStockItem.StockNo = 1;
            
            TestStockItem.StockItemDescription = "Completely rubbish software";
            TestStockItem.StockLevel = 12;
            TestStockItem.StockName = "Microsoft Windows 10";
            TestStockItem.ItemPrice = 300;
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
        //TestItem.Active = true;
        TestItem.StockNo = 1;
        TestItem.StockItemDescription = "Completely rubbish software";
        TestItem.StockLevel = 12;
        TestItem.StockName = "Microsoft Windows 10";
        TestItem.ItemPrice = 300;
            //add the item to the test list
        TestList.Add(TestItem);
            //assign the data to the property
        AllStock.StockList = TestList;
            //test to see that the two value are the same
        Assert.AreEqual(AllStock.Count, TestList.Count);
            
    }
        //[TestMethod]
        //public void TwoItemsPresent()
        //{
        //    //create an instance of the class
        //    clsStockCollection StockItems = new clsStockCollection();
        //    //test to see that the two values are the same
        //    Assert.AreEqual(StockItems.Count, 2);

        //}
        [TestMethod]
        public void AddMethodOK()
        {

            // create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStockItem TestItem = new clsStockItem();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.StockNo = 1;
            //TestItem.ItemPrice = "2.50";
            TestItem.StockName = "Microsoft windows";
            TestItem.StockItemDescription = "Something really useful";
            TestItem.StockLevel = 5;
            TestItem.SupplierName = "Someone really wealthy";
            //set ThisStockItem to the test data
            AllStock.ThisStockItem = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockNo = PrimaryKey;
            //find the record
            AllStock.ThisStockItem.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStockItem, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {

            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStockItem TestItem = new clsStockItem();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "Windows 457";
            TestItem.StockItemDescription = "Some software for doing stuff";
            TestItem.StockLevel = 1;
            TestItem.ItemPrice = 23;
            TestItem.SupplierName = "Some Supplier";
            //set ThisStockItem to the test data
            AllStock.ThisStockItem = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockNo = PrimaryKey;
            //find the record
            AllStock.ThisStockItem.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStockItem.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStockItem TestItem = new clsStockItem();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockName = "some stock item";
            TestItem.StockItemDescription = "Some description of something";
            TestItem.StockLevel = 4;
            TestItem.ItemPrice = 5;
            TestItem.SupplierName = "Someone who supplies something LTD";
            //set ThisStockItem to the test data
            AllStock.ThisStockItem = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockNo = PrimaryKey;
            //modify the test data
            TestItem.StockName = "Another stock item";
            TestItem.StockItemDescription = "A load of rubbish";
            TestItem.StockLevel = 27;
            TestItem.ItemPrice = 40;
            TestItem.SupplierName = "Someone else who supplies something LTD";
            //set the record based on the new test data
            AllStock.ThisStockItem = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStockItem.Find(PrimaryKey);
            //test to see ThisStockItem matches the test data
            Assert.AreEqual(AllStock.ThisStockItem, TestItem);

        }
    }
        
        }



