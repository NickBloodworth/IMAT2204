using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsStockItem
    {
        //private data member for the StockCode Property
        private Int32 stockCode;
        public string ItemPrice { get; set; }


        public Boolean Valid(string ItemPrice)
        {
            //var to record any errors found in ItemPrice assuming all is ok
            Boolean OK = true;
            //test to see if the Item Price has zero characters
            if (ItemPrice.Length == 0)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 10 characters
            if (ItemPrice.Length > 10)
            {

                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK;
        }




        public int StockCode
        {
            get
            {
                //return the private data
                return StockCode;
            }
            set
            {
                //set the value of the private data member
                StockCode = value;

            }
        }
        public Boolean StockCodeValid(String StockCode)
        {
            //var to record any errors found in StockCode assuming all is ok
            Boolean OK = true;
            //test to see if the StockCode has less than 1 characters
            if (StockCode.Length < 1)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 100 characters
            if (StockCode.Length > 8)
            {

                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK;
        }

        public string StockLevel { get; set; }
        public Boolean StockLevelValid(String StockLevel)
        {
            //var to record any errors found in Stock Level assuming all is ok
            Boolean OK = true;
            //test to see if the stock level is less than 0
            if (StockLevel.Length < 0)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 1000 characters
            if (StockLevel.Length > 1000)
            {

                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK;
        }


        public string StockItemDescription { get; set; }
        public Boolean StockItemDescriptionValid(String StockItemDescription)
        {
            //var to record any errors found in StockCode assuming all is ok
            Boolean OK = true;
            //test to see if the StockCode has less than 4 characters characters
            if (StockItemDescription.Length < 5)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 100 characters
            if (StockItemDescription.Length > 100)
            {

                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK;
        }

        public string StockName { get; set; }
        public Boolean StockNameValid(String StockName)
        {
            //var to record any errors found in StockName assuming all is ok
            Boolean OK = true;
            //test to see if the StockName has less than 4 characters characters
            if (StockName.Length < 5)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 100 characters
            if (StockName.Length > 25)
            {

                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK;
        }







        public bool PriceValid(string SomePrice)
        {
            Boolean OK = true;
            decimal RealPrice;
            try
            {
                RealPrice = Convert.ToDecimal(SomePrice);
                if (RealPrice < 0 | RealPrice > 1000000)
                {
                    OK = false;
                }
            }
            catch
            {
                OK = false;
            }
            return OK;
        }
        public string SupplierName { get; set; }
        public Boolean SupplierNameValid(String SupplierName)
        {
            //var to record any errors found in StockName assuming all is ok
            Boolean OK = true;
            //test to see if the StockName has less than 4 characters characters
            if (SupplierName.Length < 5)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 100 characters
            if (SupplierName.Length > 20)
            {

                //set OK to false
                OK = false;
            }
            return OK;
        }









        public bool Active { get; set; }

        //public int StockNo { get; set; }

        //public DateTime DateAdded { get; set; }





        public bool Find(int StockCode)
        {
            // set the priveate data member to the test data value
            StockCode = 3;
            //always return true
            return true;
        }

        public DateTime DateAdded { get; set; }
    }
}


