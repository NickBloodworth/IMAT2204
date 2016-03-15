using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //protected void btnStockControl_Click(object sender, EventArgs e)
        //{
        //    //call the display users function
        //    lblError.Text = DisplayStock() + "found";
        //}
        //Int32 DisplayStock()
        //{
        //    //create an instance of the user collection
        //    clsStockCollection MyStock = new clsStockCollection();
        //    //find all users
        //    MyStock.FindAllStock();
        //    //set the data source of the list box
        //    lstUsers.DataSource = MyStock.stockList;
        //    //set the text to be displayed
        //    lstUsers.DisplayMember = "StockName";
        //    //ser the primary key value
        //    lstUsers.ValueMember = "StockNo";

        //    //return the count of records in the list
        //    return MyStock.Count;


        //}
    }
}
