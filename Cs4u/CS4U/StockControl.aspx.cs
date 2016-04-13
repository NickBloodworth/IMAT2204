﻿using System;
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

        }

        protected void btnAddStock_Click(object sender, EventArgs e)
        {
            //store -1 onto the session object to indicate this is an new record
            Session["StockNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AddStock.aspx");
        }
    }
}