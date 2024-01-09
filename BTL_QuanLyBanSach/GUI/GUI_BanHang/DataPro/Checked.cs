using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DataPro
{
    internal class Checked
    {
        public static Boolean Check(string test) 
        {
            if(test == "")
            {
                return true;
            }
            else return false;
        }
        public static string CheckBill(string BillID, string EmployeeID, string CustomerId)
        {
            string check;
            if (BillID == "")
                return check = "bill";
            else if (EmployeeID == "")
                return check = "employee";
            else if (CustomerId == "")
                return check = "customer";
            else return check = "all";
        }

        public static string CheckBillDetail(string BookID, string Price, string Amount)
        {
            string check;
            if (BookID == "")
                return check = "book";
            else if (Price == "")
                return check = "price";
            else if (Amount == "")
                return check = "amount";
            else return check = "all";
        }
    }
    
}
