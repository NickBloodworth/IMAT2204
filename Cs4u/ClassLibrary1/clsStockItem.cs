using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsStockItem
    {
        //private data members for the Properties
        private Int32 stockCode;
        private decimal itemPrice;
        private Int32 stockLevel;
        private string stockItemDescription;
        private string stockName;
        private string supplierName;
        private DateTime dateAdded;
        private Boolean active;
                
        


        public Boolean Valid(String ItemPrice)
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
        public decimal ItemPrice
        {
            get 
            { 
            //return the private data
                return itemPrice;
            }
            set 
            {
                itemPrice = value;
            }
        }
        public int StockLevel
        {
            get 
            {
                return stockLevel;
            }
            set 
            {
                stockLevel = value;
            }
        }

        public string StockItemDescription
        {
            get 
            {
                return stockItemDescription;
            }
            set 
            {
                stockItemDescription = value;
            }
        }

        public string StockName
        {
            get 
            {
                return stockName;
            }
            set 
            {
                stockName = value;
            }
        }
        public string SupplierName
        {
            get 
            {
                return supplierName;
            }
            set 
            {
                supplierName = value;
            }
        }


        public int StockNo
        {
            get
            {
                //return the private data
                return stockCode;
            }
            set
            {
                //set the value of the private data member
                stockCode = value;

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

        
        public Boolean StockLevelValid(String StockLevel)
        {
            //var to record any errors found in Stock Level assuming all is ok
            Boolean OK = true;
            //test to see if the stock level is less than 0
            if (StockLevel.Length < 1)
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







        public bool PriceValid(String SomePrice)
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

        //public bool Active 
        //{ 
        //    get 
        //{ 
        //        //return the private data
        //    return active;
                
        //    }
        //    set 
        //    { 
        //        //set the private data
        //        active = value;
        //        }
        //}

        //public int StockNo { get; set; }

      
        public bool Find(int StockNo)
        {
            //creat an instanc of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock code to search for
            DB.AddParameter("@StockNo", StockNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStockItem_FilterByStockNo");
            //if one record is found
            if(DB.Count==1)
            {
                //copy the data from the databas to the private data member
                stockCode = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                itemPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPrice"]);
                stockLevel=Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                stockItemDescription=Convert.ToString(DB.DataTable.Rows[0]["StockItemDescription"]);
                stockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                supplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                //dateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;

            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }

        //public DateTime DateAdded 
        //{
        //    get
        //    {
        //        return dateAdded ;
        //    }
        //    set 
        //    { 
        //        dateAdded=value;
        //    }
        //}
        //public bool Found 
        //{
        //    get 
        //    {
        //        return found
        //        ;}
        //    set 
        //    { 
        //        found =value;}
        //}
        
        


        
    }
}



