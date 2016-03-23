using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS4U
{

    public partial class Delete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the stock item to be deleted from the session object
            StockNo = Convert.ToInt32(Session["StockNo"]);
        }
        void DeleteStockItem()
        {
            //function to delete the selected record
            //create a new instance of the StockItems
            clsStockCollection StockItems = new clsStockCollection();
            //find the record to delete
            StockItems.ThisStockItem.Find(StockNo);
            //delete the record
            StockItems.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStockItem();
            //redirect back to the main page
            Response.Redirect("StockControl.aspx");
        }
        
    }
    
}