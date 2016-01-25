using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace CS4u_Test_Framework
{
    [TestClass]
    public class tststockItem
    {
        [TestMethod]
        public void InstantiationOk()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
        }
        [TestMethod]
    
    //used to test the Item Price property of the class
    public void ItemPrice()
    {

        //create an instance of the class
        clsStockItem AStockItem = new clsStockItem();
        //create a variable to store the price of an item
        string SomePrice;
        //assign an item price to the variable
        SomePrice = "10.00";
        //try to send some data to the ItemPrice property
        AStockItem.ItemPrice = "10.00";
        //check to see that the data in the variable and the propery are the sam
        Assert.AreEqual(AStockItem.ItemPrice, SomePrice);
    }

    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceValidOK()
    { 
    //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();
        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("10.10");
        Assert.IsTrue(OK);
    }

    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceExtremeMin()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();
        
        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("-10000000");
        Assert.IsFalse(OK);
    }


    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceMinLessOne()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("-0.01");
        Assert.IsFalse(OK);
    }

    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceMinPlusOne()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("0.01");
        Assert.IsTrue(OK);
    }


    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceMid()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("500000");
        Assert.IsTrue(OK);
    }


    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceMaxLessOne()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("999999.99");
        Assert.IsTrue(OK);
    }


    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceMaxBoundary()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("1000000.00");
        Assert.IsTrue(OK);
    }


    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceMaxPlusOne()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("1000000.01");
        Assert.IsFalse(OK);
    }


    [TestMethod]
    //used to test the prsence of the valid method
    public void PriceExtremeMax()
    {
        //create and instance of the class
        clsStockItem AStockItem = new clsStockItem();

        Boolean OK;
        //test to see if the valid method exists
        OK = AStockItem.PriceValid("10000000");
        Assert.IsFalse(OK);
    }


        /*[TestMethod]
        //test that the item price validation throws an error when item price is less than 3 characters
        public void ItemPriceMinLessOne()
        { 
        //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a blank string
            OK = AStockItem.Valid("10");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }*/
        [TestMethod]
        //test that the item price  validation throws an error when item price is more than 10 characters
        public void ItemPriceMaxPlusOne ()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(11);
            //test the valid method with a two character string
            OK = AstockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void ItemPriceExtremeMax()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(100);
            //test the valid method with a two character string
            OK = AStockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
       /* [TestMethod]

        //used to test the StockCode property of the class
        public void StockCode()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //try to send some data to the StockCode property
            AStockItem.StockCode = "12345";
        
            
        }*/
        [TestMethod]
        public void StockCode()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeCode;
            //assign an item price to the variable
            SomeCode = "12345";
            //try to send some data to the ItemPrice property
            AStockItem.StockCode = SomeCode;
            //check to see that the data in the variable and the propery are the sam
            Assert.AreEqual(AStockItem.StockCode, SomeCode);

        }
        [TestMethod]
        public void StockCodeMinLessOne()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a blank string
            OK = AStockItem.Valid("");
            //assert that the outcome should be flase
            Assert.IsFalse(OK);
        }
        //[TestMethod]
        ////test that the Stock Code  validation throws an error when item price is more than 8 characters
        //public void StockCodeMaxPlusOne()
        //{
        //    //create and instance of the class
        //    clsStockItem AstockItem = new clsStockItem();
        //    //create a varaible to record the result of the validation test
        //    Boolean OK;
        //    //create a variable to store the test data
        //    string SomeText = "";
        //    //pad the data to the required number of characters
        //    SomeText = SomeText.PadLeft(9);
        //    //test the valid method with a two character string
        //    OK = AstockItem.Valid(SomeText);
        //    //assert that the outcome should be true
        //    Assert.IsFalse(OK);

        //}
        [TestMethod]
        public void StockCodeExtremeMax()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(50);
            //test the valid method with a two character string
            OK = AStockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StockLevel()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeLevel;
            //assign an item price to the variable
            SomeLevel = "12";
            //try to send some data to the ItemPrice property
            AStockItem.StockLevel = SomeLevel;
            //check to see that the data in the variable and the propery are the sam
            Assert.AreEqual(AStockItem.StockLevel, SomeLevel);

        }
        //[TestMethod]
        //public void StockLevelMinLessOne()
        //{

        //    //create an instance of the class
        //    clsStockItem AStockItem = new clsStockItem();
        //    //create a variable to record the result of the validation test
        //    Boolean OK;
        //    //test the valid method with a blank string
        //    OK = AStockItem.Valid("-1");
        //    //assert that the outcome should be flase
        //    Assert.IsFalse(OK);
        //}
        [TestMethod]
        public void StockLevelExtremeMax()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(1000000);
            //test the valid method with a two character string
            OK = AStockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        //test that the Stock Code  validation throws an error when item price is more than 8 characters
        public void StockLevelMaxPlusOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(1001);
            //test the valid method with a two character string
            OK = AstockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void StockItemDescription()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeDescription;
            //assign an item price to the variable
            SomeDescription = "Windows 2010";
            //try to send some data to the ItemPrice property
            AStockItem.StockItemDescription = SomeDescription;
            //check to see that the data in the variable and the propery are the sam
            Assert.AreEqual(AStockItem.StockItemDescription, SomeDescription);

        }
        [TestMethod]
        //test that the Stock Code  validation throws an error when item price is more than 8 characters
        public void StockItemDescriptionMaxPlusOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(101);
            //test the valid method with a two character string
            OK = AstockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void StockItemDescriptionExtremeMax()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(1000);
            //test the valid method with a two character string
            OK = AStockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        //[TestMethod]
        //public void StockItemDescriptionMinLessOne()
        //{

        //    //create an instance of the class
        //    clsStockItem AStockItem = new clsStockItem();
        //    //create a variable to record the result of the validation test
        //    Boolean OK;
        //    //test the valid method with a blank string
        //    OK = AStockItem.Valid("4");
        //    //assert that the outcome should be flase
        //    Assert.IsFalse(OK);
        //}
        [TestMethod]
        public void StockName()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeName;
            //assign an item name to the variable
            SomeName = "Windows 2010";
            //try to send some data to the ItemPrice property
            AStockItem.StockName = SomeName;
            //check to see that the data in the variable and the propery are the sam
            Assert.AreEqual(AStockItem.StockName, SomeName);

        }
        //[TestMethod]
        //public void StockNameMinLessOne()
        //{

        //    //create an instance of the class
        //    clsStockItem AStockItem = new clsStockItem();
        //    //create a variable to record the result of the validation test
        //    Boolean OK;
        //    //test the valid method with a blank string
        //    OK = AStockItem.Valid("4");
        //    //assert that the outcome should be flase
        //    Assert.IsFalse(OK);
        //}
        [TestMethod]
        public void StockNameExtremeMax()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(1000);
            //test the valid method with a two character string
            OK = AStockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        //test that the Stock Code  validation throws an error when item price is more than 8 characters
        public void StockNameMaxPlusOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(26);
            //test the valid method with a two character string
            OK = AstockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierName()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeSupplier;
            //assign an item name to the variable
            SomeSupplier = "Bloggs & Co";
            //try to send some data to the ItemPrice property
            AStockItem.StockName = SomeSupplier;
            //check to see that the data in the variable and the propery are the sam
            Assert.AreEqual(AStockItem.StockName, SomeSupplier);

        }
        [TestMethod]
        //test that the Stock Code  validation throws an error when item price is more than 8 characters
        public void SupplierNameMaxPlusOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(21);
            //test the valid method with a two character string
            OK = AstockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(1000);
            //test the valid method with a two character string
            OK = AStockItem.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        //[TestMethod]
        //public void SupplierNameMinLessOne()
        //{

        //    //create an instance of the class
        //    clsStockItem AStockItem = new clsStockItem();
        //    //create a variable to record the result of the validation test
        //    Boolean OK;
        //    //test the valid method with a blank string
        //    OK = AStockItem.Valid("4");
        //    //assert that the outcome should be flase
        //    Assert.IsFalse(OK);
        //}
    }
}
