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
       /* public Boolean Valid(string StockCode)
        {
            //var to record any errors found in StockCode assuming all is ok
            Boolean OK = true;
            //test to see if the StockCode has zero characters
            if (StockCode.Length == 0)
            {

                //set OK to false
                OK = false;
            }

            //test to see that the string is no more than 8 characters
            if (StockCode.Length > 8)
            {

                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK;
        }*/

        public string StockLevel { get; set; }

        public string StockItemDescription { get; set; }

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
    }
}
