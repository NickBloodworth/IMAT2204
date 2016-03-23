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



        //private data member that stores the count of records found
        private Int32 recordCount;
        //create a private list data member to store the data from the database
        private List<clsStockItem> allStock = new List<clsStockItem>();
        clsStockItem thisStockItem = new clsStockItem();
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
                AStockItem.StockNo = Convert.ToInt32(myDB.DataTable.Rows[Index]["StockNo"]);

                //increment the index
                Index++;
                ////get the user number from the database
                //StockNo = Convert.ToInt32(myDB.DataTable.Rows[Index]["StockNo"]);
                ////find the user by invoking the find method
                //StockFound = NewItem.Find(StockNo);
                //if (StockFound == true)
                //{
                //    //add the user to the list
                allStock.Add(AStockItem);
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
                allStock = value;
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

        public int RecordCount
        {
            get
            {
                return recordCount;
            }
            set
            {
                recordCount = value;
            }
        }

        public clsStockItem ThisStockItem
        {
            get
            {
                //return the private data
                return thisStockItem;
            }

            set
            {
                //set the private data
                thisStockItem = value;
            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStockItem
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@StockNo", thisStockItem.StockNo);
            DB.AddParameter("@ItemPrice", thisStockItem.ItemPrice);
            DB.AddParameter("@StockLevel", thisStockItem.StockLevel);
            DB.AddParameter("@StockItemDescription", thisStockItem.StockItemDescription);
            DB.AddParameter("@StockName", thisStockItem.StockName);
            DB.AddParameter("@SupplierName", thisStockItem.SupplierName);


            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStockItem_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStockItem
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockNo", thisStockItem.StockNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStockItem_Delete");
        }
        ////function for adding new records
        //void Add()
        //{

        //    //create an instance of the Stockrecords
        //    clsStockCollection StockItems = new clsStockCollection();
        //    //validate the data on the web form
        //    Boolean OK = StockItems.ThisStockItem.Valid(txtStockName.Text, txtItemPrice.Text, txtItemDescription.Text, txtSupplierName.Text, txtStockLevel.Text);


        //    //if the data is OK then add it to the onject


        //    if (OK == true)
        //    {

        //        //get the data entered by the user

        //        StockItems.ThisStockItem.StockName = txtStockName.Text;
        //        StockItems.ThisStockItem.ItemPrice = txtItemPrice.Text;
        //        StockItems.ThisStockItem.StockItemDescription = txtStockDescription.Text;
        //        StockItems.ThisStockItem.StockLevel = txtStockLevel.Text;
        //        StockItems.ThisStockItem.SupplierName = txtSupplierName.Text;
        //        //add the record
        //        StockItems.Add();
        //    }
        //    else
        //    {
        //        //report an error
        //        lblError.Text = "There were problems with the data entered";
        //    }

        //}

        public void Update()
        {
            //update an existing record based on the values of thisStockItem
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockNo", thisStockItem.StockNo);
            DB.AddParameter("@ItemPrice", thisStockItem.ItemPrice);
            DB.AddParameter("@StockLevel", thisStockItem.StockLevel);
            DB.AddParameter("@StockItemDescription", thisStockItem.StockItemDescription);
            DB.AddParameter("@StockName", thisStockItem.StockName);
            DB.AddParameter("@SupplierName", thisStockItem.SupplierName);
            //execute the stored procedure
            DB.Execute("sproc_tblStockItem_Update");
        }
        void DisplayStockItem()
        {
            //create an instance of the StockItems
            clsStockCollection StockItems = new clsStockCollection();
            //find the record to update
            StockItems.ThisStockItem.Find(StockNo);
            //display the data for this record
            txtStockName.Text = StockItems.ThisStockItem.StockName;
            txtStockDescription.Text = StockItems.ThisStockItem.StockItemDescription;
            txtItemPrice.Text = StockItems.ThisStockItem.ItemPrice;
            txtSupplierName.Text = StockItems.ThisStockItem.SupplierName;
            txtStockLevel.Text = StockItems.ThisStockItem.StockLevel;
            ddlStockItem.SelectedValue = StockItems.ThisStockItem.StockNo.ToString();
        }
    }
}
