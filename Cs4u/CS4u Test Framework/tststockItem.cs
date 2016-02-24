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
            Assert.IsNotNull(AStockItem);
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
        public void PriceMinBoundary()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.PriceValid("0.01");
            Assert.IsTrue(OK);
        }


        [TestMethod]
        //used to test the presence of the valid method
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
        //used to test the presence of the valid method
        public void PriceExtremeMax()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.PriceValid("10000000");
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StockCode()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            Int32 SomeCode;
            //assign an item code to the variable
            SomeCode = 12345;
            //try to send some data to the StockCode property
            AStockItem.StockCode = SomeCode;
            //check to see that the data in the variable and the propery are the sam
            Assert.AreEqual(AStockItem.StockCode, SomeCode);

        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeValidOK()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();
            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("12345");
            Assert.IsTrue(OK);

        }

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
            SomeText = SomeText.PadLeft(1000);
            //test the valid method with a two character string
            OK = AStockItem.StockCodeValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeMinLessOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("");
            Assert.IsFalse(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeMinBoundary()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("1");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeMinPlusOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("2");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeMaxBoundary()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("8");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeMaxBoundaryLessOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("7");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockCodeMid()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockCodeValid("4");
            Assert.IsTrue(OK);
        }


        [TestMethod]

        //used to test the Stock Level property of the class
        public void StockLevel()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the stock level of an item
            string SomeLevel;
            //assign an stock level to the variable
            SomeLevel = "12";
            //try to send some data to the StockLevel property
            AStockItem.StockLevel = "12";
            //check to see that the data in the variable and the propery are the same
            Assert.AreEqual(AStockItem.StockLevel, SomeLevel);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockLevelValidOK()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();
            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockLevelValid("12");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the presence of the valid method
        public void StockLevelMinBoundary()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockLevelValid("0");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockLevelMinPlusOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockLevelValid("1");
            Assert.IsTrue(OK);
        }

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
            OK = AStockItem.StockCodeValid(SomeText);
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StockLevelMaxLessOne()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(999);
            //test the valid method with a two character string
            OK = AStockItem.StockLevelValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StockLevelMid()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(500);
            //test the valid method with a two character string
            OK = AStockItem.StockLevelValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StockLevelMaxBoundary()
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
            OK = AStockItem.StockLevelValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //test that the Stock Level  validation throws an error when Stock Level is more than 8 characters
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
            OK = AstockItem.StockLevelValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockItemDescriptionValidOK()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();
            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockItemDescriptionValid("PCPackage");
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void StockItemDescription()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the description of an item
            string SomeDescription;
            //assign an item price to the variable
            SomeDescription = "Windows 2010";
            //try to send some data to the StockItemDescription property
            AStockItem.StockItemDescription = SomeDescription;
            //check to see that the data in the variable and the property are the sam
            Assert.AreEqual(AStockItem.StockItemDescription, SomeDescription);

        }
        [TestMethod]
        //test that the Stock Code  validation throws an error when description is more than 8 characters
        public void StockItemDescriptionMid()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(50);
            //test the valid method with a two character string
            OK = AstockItem.StockItemDescriptionValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the StockItemDescription  validation throws an error when description is more than 8 characters
        public void StockItemDescriptionMaxLessOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(99);
            //test the valid method with a two character string
            OK = AstockItem.StockItemDescriptionValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the StockItemDescription  validation throws an error when description is more than 8 characters
        public void StockItemDescriptionMaxBoundary()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(100);
            //test the valid method with a two character string
            OK = AstockItem.StockItemDescriptionValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the StockItemDescription  validation throws an error when 
        //StockItemDescription is more than 8 characters
        public void StockItemDescriptionMinBoundary()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(5);
            //test the valid method with a two character string
            OK = AstockItem.StockItemDescriptionValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockItemDescriptionMinLessOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockItemDescriptionValid("4444");
            Assert.IsFalse(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockItemDescriptionMinPlusOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockItemDescriptionValid("pppppp");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //test that the StockItemDescription  validation throws an error 
        //when StockItemDescription is more than 8 characters
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
            OK = AstockItem.StockCodeValid(SomeText);
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
            OK = AStockItem.StockItemDescriptionValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StockName()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeName;
            //assign an item name to the variable
            SomeName = "Windows 2010";
            //try to send some data to the StockName property
            AStockItem.StockName = SomeName;
            //check to see that the data in the variable and the 
            //property are the same
            Assert.AreEqual(AStockItem.StockName, SomeName);

        }

        [TestMethod]
        public void StockNameMid()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(12);
            //test the valid method with a two character string
            OK = AStockItem.StockNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockNameMinBoundary()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockNameValid("55555");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockNameMinPlusOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockNameValid("555555");
            Assert.IsTrue(OK);
        }
        [TestMethod]
        //used to test the presence of the valid method
        public void StockNameMinLessOne()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();

            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockNameValid("5555");
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void StockNameMaxBoundary()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(25);
            //test the valid method with a two character string
            OK = AStockItem.StockNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        //used to test the presence of the valid method
        public void StockNameValidOK()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();
            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.StockNameValid("12111");
            Assert.IsTrue(OK);
        }
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
            OK = AStockItem.StockNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        //test that the StockName  validation throws an error when 
        //StockName is more than 8 characters
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
            OK = AstockItem.StockNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        //test that the SupplierName validation throws an error when SupplierName 
        //is more than 8 characters
        public void SupplierNameMaxLessOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(19);
            //test the valid method with a two character string
            OK = AstockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the SupplierName  validation throws an error when SupplierName is more than 8 characters
        public void SupplierNameMid()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(10);
            //test the valid method with a two character string
            OK = AstockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the SupplierName  validation throws an error when SupplierName
        //is more than 8 characters
        public void SupplierNameMinPlusOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(6);
            //test the valid method with a two character string
            OK = AstockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the SupplierName  validation throws an error when SupplierName
        //is more than 8 characters
        public void SupplierNameMinBoundary()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(5);
            //test the valid method with a two character string
            OK = AstockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);

        }
        [TestMethod]
        //test that the SupplierName  validation throws an error when SupplierName
        //is more than 8 characters
        public void SupplierNameMinLessOne()
        {
            //create and instance of the class
            clsStockItem AstockItem = new clsStockItem();
            //create a varaible to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(4);
            //test the valid method with a two character string
            OK = AstockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        //test that the SupplierName  validation throws an error when SupplierName
        //is more than 8 characters
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
            OK = AstockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SupplierNameMaxBoundary()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(20);
            //test the valid method with a two character string
            OK = AStockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SupplierName()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create a variable to store the code of an item
            string SomeSupplier;
            //assign an item code to the variable
            SomeSupplier = "12354";
            //try to send some data to the StockCode property
            AStockItem.SupplierName = SomeSupplier;
            //check to see that the data in the variable and the property are the sam
            Assert.AreEqual(AStockItem.SupplierName, SomeSupplier);

        }
        [TestMethod]
        //used to test the presence of the valid method
        public void SupplierNameValidOK()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();
            Boolean OK;
            //test to see if the valid method exists
            OK = AStockItem.SupplierNameValid("12111");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //used to test the presence of the valid method
        public void ActiveOK()
        {
            //create and instance of the class
            clsStockItem AStockItem = new clsStockItem();
            Boolean TestData = true;
            AStockItem.Active = TestData;
            Assert.AreEqual(TestData, AStockItem.Active);
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
            OK = AStockItem.SupplierNameValid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStockItem.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.DateAdded, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockCode = 1;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStockCodeFound()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockCode = 3;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //check the stock no
            if (AStockItem.StockCode != 3)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void StockCodePropertyOK()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStockItem.StockCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.StockCode, TestData);
        }
        [TestMethod]
        public void ItemPricePropertyOK()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            decimal TestData = 1;
            //assign the data to the property
            AStockItem.ItemPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.ItemPrice, TestData);
        }

        [TestMethod]
        public void StockLevelPropertyOK()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStockItem.StockLevel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.StockLevel, TestData);
        }
        [TestMethod]
        public void StockItemDescriptionPropertyOK()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            string TestData = "something here";
            //assign the data to the property
            AStockItem.StockItemDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.StockItemDescription, TestData);
        }
        [TestMethod]
        public void StockNamePropertyOK()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            String TestData = "somename";
            //assign the data to the property
            AStockItem.StockName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.StockName, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {

            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //create some test data to assign to the property
            String TestData = "someone";
            //assign the data to the property
            AStockItem.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStockItem.SupplierName, TestData);
        }
        [TestMethod]
        public void TestStockItemDescriptionFound()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use within the method
            Int32 StockCode = 2;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //check the property
            if (AStockItem.StockItemDescription != "Test StockItemDescription")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStockNameFound()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use within the method
            Int32 StockCode = 2;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //check the property
            if (AStockItem.StockName != "Some name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestItemPriceFound()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            decimal ItemPrice = 3;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //check the stock no
            if (AStockItem.StockCode != 3)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockLevelFound()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemPrice = 3;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //check the stock no
            if (AStockItem.StockLevel != 3)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class
            clsStockItem AStockItem = new clsStockItem();
            //boolean variable to record if daa is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockCode = 3;
            //invoke the method
            Found = AStockItem.Find(StockCode);
            //check the property
            if (AStockItem.DateAdded !=Convert.ToDateTime("01/04/2016"))
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        
    }
}
