using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsOrderLine
    {
        public object OrderNo { get; set; }

        public bool Valid(string ItemCode)
        {
            //if the name of the item code is blank
            if (ItemCode != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object LineCost { get; set; }
    }
}
