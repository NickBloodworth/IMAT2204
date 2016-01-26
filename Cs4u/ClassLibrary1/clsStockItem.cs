using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsStockItem
    {
        public string ItemPrice { get; set; }


        public Boolean Valid(string ItemPrice)
        {
            //var to record any errors found in ItemPrice assuming all is ok
            Boolean OK = true;
            //test to see if the Item Price has zero characters
            if(ItemPrice.Length==0)
            {

                //set OK to false
                OK = false;
            }

                    //test to see that the string is no more than 10 characters
                    if (ItemPrice.Length>10)
                    {

                        //set OK to false
                        OK=false;
                    }
            
            //return the results of all tests
            return OK;
        }


        

        public string StockCode { get; set; }
       public Boolean StockCodeValid(String StockCode)
        {
            //var to record any errors found in StockCode assuming all is ok
            Boolean OK = true;
            //test to see if the StockCode has less than 1 characters
            if (StockCode.Length <1)
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
            if (StockLevel.Length <0)
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

        internal bool Find(int StockNo)
        {
            throw new NotImplementedException();
        }




        public bool PriceValid(string SomePrice)
        {
            Boolean OK = true;
            decimal RealPrice;
            try
            {
                RealPrice = Convert.ToDecimal(SomePrice);
                if (RealPrice < 0 | RealPrice>1000000)
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

       // public bool StockCodeValid(string p)
      //  {
        //    throw new NotImplementedException();
        //}

        public bool SupplierNameValid(string SomeText)
        {
            throw new NotImplementedException();
        }
    }
}
