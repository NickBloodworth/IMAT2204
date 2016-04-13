using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS4U
{
    public partial class Main_Interface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStockControl_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockControl.aspx");
        }
    }
}