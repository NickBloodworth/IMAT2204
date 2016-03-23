using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS4U
{
    public partial class StockControl : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
//variable to store the primary key value of the Stock Item to be processed
        StockNo = Convert.ToInt32(Session["StockNo"]);
        if (IsPostback==false)
    {
        //populate the list of StockItems
        DisplayStockItems();
    }
        }

        protected void btnAddStock_Click(object sender, EventArgs e)
        {
            //store -1 ontp the sessopmp bject tp omdocate tjos os a mew recprd
            Session["StockNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AddStock.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be delete
            Int32 StockNo;
            //if the record has been selected from the list
            if(lstStockItems.SelectedIndex !=-1)
            {

                //get the primary key value of the record to delete
                StockNo = Convert.ToInt32(lstStockItems.SelectedValue);
                //store the data in the session object
                Session["StockNo"] = StockNo;
                //redirect to the delete page
                Response.Redirect("Delete.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 StockNo;
            //if a record has been selected from the list
            if (lstStockItems.SelectedIndex !=-1)
            {
                //get the primary key value of the record to deit
                StockNo = Convert.ToInt32(lstStockItems.SelectedValue);
                //store the data in the session object
                Session["StockNo"] = StockNo;
                //redirect to the edit page
                Response.Redirect("AddStock.aspx);
                
            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text="Please select a record to update";

            }
        }
    }
}


