using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyBanSach.DTO
{
    internal class Vendor
    {
        private string VendorID;
        private string VendorName;
        private int Status;
        public Vendor(DataRow row)
        {
            this.VendorID1 = (string)row["VendorID"];
            this.VendorName1 = (string)row["VendorName"];
			this.Status1 = (int)row["Status"];
		}

        public string VendorID1 { get => VendorID; set => VendorID = value; }
        public string VendorName1 { get => VendorName; set => VendorName = value; }
		public int Status1 { get => Status; set => Status = value; }

		public Vendor(string vendorID, string vendorName, int status)
        {
            this.VendorID = vendorID;
            this.VendorName = vendorName;
            this.Status = status;
        }
    }
}
