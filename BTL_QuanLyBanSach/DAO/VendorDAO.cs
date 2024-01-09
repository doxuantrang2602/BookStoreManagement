using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_QuanLyBanSach.DTO;

namespace BTL_QuanLyBanSach.DAO
{
    internal class VendorDAO
    {
        private static VendorDAO instance { get; set; }
        DataProcesserTrang dtBase = new DataProcesserTrang();
        public static VendorDAO Instance
        {
            get { if (instance == null) instance = new VendorDAO(); return instance; }
            private set { instance = value; }
        }
        private VendorDAO() { }
        public List<Vendor> LoadVendorList()
        {
            List<Vendor> list = new List<Vendor>();
            DataTable dataVendor = dtBase.ReadData("Select * from Vendor");
            foreach (DataRow item in dataVendor.Rows)
            {
                Vendor vendor = new Vendor(item);
                list.Add(vendor);
            }
            return list;
        }
    }
}
