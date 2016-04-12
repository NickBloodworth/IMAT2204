using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;


public partial class AddStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the StockItem to be processede
        StockNo = Convert.ToInt32(Session["StockNo"]);
        if (IsPostBack == false)
        {
            //populate the list of stock items
            DisplayStockItems();
            //if this is not a new record
            if (StockNo != -1)
            {
                //display the current data for the record
                DisplayStockItem();
            }
        }

    }


    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StockNo == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("StockControl.aspx");
    }


    //function for adding new records
    void Add()
    {
        //create an instance of the Stockrecords
        clsStockCollection StockItems = new clsStockCollection();
        //validate the data on the web form
        Boolean OK = StockItems.ThisStockItem.Valid(txtStockName.Text, txtItemPrice.Text, txtItemDescription.Text, txtSupplierName.Text, txtStockLevel.Text);
        //if the data is OK then add it to the onject
        if (OK == true)
        {

            //get the data entered by the user

            StockItems.ThisStockItem.StockName = txtStockName.Text;
            StockItems.ThisStockItem.ItemPrice =Convert.ToDecimal( txtItemPrice.Text);
            StockItems.ThisStockItem.StockItemDescription = txtItemDescription.Text;
            StockItems.ThisStockItem.StockLevel =Convert.ToInt32( txtStockLevel.Text);
            StockItems.ThisStockItem.SupplierName = txtSupplierName.Text;
            //add the record
            StockItems.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered";
        }

    }
}