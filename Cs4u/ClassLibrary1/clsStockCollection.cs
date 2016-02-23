using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsStockCollection
    {

        //public  int Count { get; set; }
        //public  object StockList { get; set; }
        public  object ThisStockItem { get; set; }


        //private data member that stores the count of records found
        private Int32 recordCount;
        //create a private list data member to store the data from the database
        private List<clsStockItem> allStock = new List<clsStockItem>();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();


        //public void FindAllStockItems()
        public clsStockCollection()
        {
            //re-set the connection
            clsDataConnection myDB = new clsDataConnection();
//execute the stored procedure
            myDB.Execute("sproc_tblStockItem_SelectAll");
//get the count of records
            Int32 recordCount = myDB.Count;

            //var to store the index
            Int32 Index = 0;
//while there are still records to process
            while (Index < myDB.Count)
            ////var to store the user number of the current record
            //Int32 StockNo;
            ////var to flag that user was found
            //Boolean StockFound;
            
            
            
            {
                //create an instance of the stock item class
                clsStockItem AStockItem = new clsStockItem();
                //get the stock name
                AStockItem.StockName = myDB.DataTable.Rows[Index]["StockName"].ToString();
                //get the primary key
                AStockItem.StockCode = Convert.ToInt32(myDB.DataTable.Rows[Index]["StockNo"]);

//increment the index
                Index++;
                ////get the user number from the database
                //StockNo = Convert.ToInt32(myDB.DataTable.Rows[Index]["StockNo"]);
                ////find the user by invoking the find method
                //StockFound = NewItem.Find(StockNo);
                //if (StockFound == true)
                //{
                //    //add the user to the list
                //    allStock.Add(NewItem);
                //}
                
            }
        }
        //public constructore for the class
        //public clsStock Collection()
        //{

        //    //create an instance of the StockItem class to store a stock item
        //    clsStockItem AStockItem = new clsStockItem();
        //    //set the item
        //    AStockItem.StockName = "Windows 2016";
        //    //add tge item to the private list of items
        //    allStock.Add(AStockItem);
        //    //re initialise the AStockItem object to accept a new item
        //    AStockItem = new clsStockItem();
        //    //set the new item
        //    AStockItem.StockName = "windows1954";
        //    //add the second item to the private list of items
        //    allStock.Add(AStockItem);
        //    //the private list now contains two items
        //}

        //public list of users
        //public List<clsStockItem> AllStock
        //{
        //    //getter for the property
        //    get
        //    {
        //        //return the list of users
        //        return allStock;
        //    }
            //setter accepts data from other objects


        

        ////public property returning the count of records
        //public Int32 Count
        //{
        //    get
        //    {
        //        //return record count;
        //        return recordCount;
        //    }
        //}

        //public class clsStockCollection
    
            //private data member for the list
            private List<clsStockItem> stocklist = new List<clsStockItem>();

            public List<clsStockItem> StockList 
            { 
                get
                {
                    //return the private data
                    return allStock;                
                }
                set
                {
                    //set the private data
                    allStock=value;
                }
            }
        
        //public  List<clsStockItem> AllStock 
        //{
        //    get
        //    {
        //        return allStock;
        //    }
        //    set
        //    {
        //        allStock = value;
        //    }
        //}


        public int Count 
        {
            get 
            {
                //return record count;
                return allStock.Count;
            }
            set 
            {
            }
        }

        //public List<clsStockItem> StockList { get; set; }

        //public clsStockItem ThisStockItem { get; set; }
    }
}
