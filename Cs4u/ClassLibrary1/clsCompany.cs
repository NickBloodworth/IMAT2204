using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class clsCompany
    {
        private DateTime DateTemp;

        public string Company { get; set; }

        public object CompanyNo { get; set; }

        public DateTime DateAdded { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool LinkedIn { get; set; }

        public int Phone { get; set; }

        public string PostCode { get; set; }

        public bool Find(int CompanyNo)
        {
            if (CompanyNo <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Valid(string CompanyNo, string Company, string PostCode, string DateAdded)
        {
            Boolean OK = true;

            if (CompanyNo.Length == 0)
            {
                OK = false;
            }
            if (CompanyNo.Length > 6)
            {
                OK = false;
            }

            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            //is the post code blank
            if (PostCode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the post code is too long
            if (PostCode.Length > 9)
            {
                //set the flag OK to false
                OK = false;
            }
            //is the street blank
            if (Company.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the street is too long
            if (Company.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }


            //return the value of OK
            return OK;
        }
    }
}
