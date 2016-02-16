using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS4U
{
    public class clsOrder
    {
        
        public int CustomerID { get; set; }
        
        public string ItemDesc { get; set; }

        public bool Valid(int CustID)
        {
            if (CustID <= 0)
            {
                return false;
            }
            else
            { 
                return true;
            }
        }

        public DateTime Date { get; set; }

        public double Price { get; set; }
    }

}
