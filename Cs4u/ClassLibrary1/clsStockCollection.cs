using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsStockCollection
    {
        //private data member that stores the count of records found
        private Int32 recordCount;
        //create a private list data member to store the data from the database
        private List<clsStockItem> items = new List<clsStockItem>();
        //private data member to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        public void FindAllStockItems()
        {
            //re-set the connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the user number of the current record
            Int32 StockNo;
            //var to flag that user was found
            Boolean StockFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblStockItem_SelectAll");
            //get the count of records
            recordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the user class
                clsStockItem NewItem = new clsStockItem();
                //get the user number from the database
                StockNo = Convert.ToInt32(myDB.DataTable.Rows[Index]["StockNo"]);
                //find the user by invoking the find method
                StockFound = NewItem.Find(StockNo);
                if (StockFound == true)
                {
                    //add the user to the list
                    items.Add(NewItem);
                }
                //increment the index
                Index++;
            }
        }

        //public list of users
        public List<clsStockItem> Items
        {
            //getter for the property
            get
            {
                //return the list of users
                return items;
            }
        }

        //public property returning the count of records
        public Int32 Count
        {
            get
            {
                //return record count;
                return recordCount;
            }
        }
    }
}
