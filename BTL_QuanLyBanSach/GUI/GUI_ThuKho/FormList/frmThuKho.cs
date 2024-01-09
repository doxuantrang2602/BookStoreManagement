using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class frmThuKho : Form
    {
        bool sideMenuExpand;
        public frmThuKho()
        {
            InitializeComponent();
            /*
            listBookUC.Show();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "DANH SÁCH HÀNG";
        }

        private void slideMenu_Tick(object sender, EventArgs e)
        {
            if (sideMenuExpand)
            {
                slideMenu.Width -= 10;
                if(slideMenu.Width == slideMenu.MinimumSize.Width) 
                {
                    sideMenuExpand = false;
                    slideTimer.Stop();
                    
                }
            }
            else
            {
                slideMenu.Width += 10;
                if (slideMenu.Width == slideMenu.MaximumSize.Width)
                {
                    sideMenuExpand= true;
                    slideTimer.Stop();

                }
            }
        }

        private void slideBtn_Click(object sender, EventArgs e)
        {
            slideTimer.Start();
        }

		private void AddpnControl(UserControl c)
		{
			c.Dock = DockStyle.Fill;
			pnControl.Controls.Clear();
			pnControl.Controls.Add(c);
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnListBooks_Click(object sender, EventArgs e)
		{
            ListBook listBook = new ListBook();
            AddpnControl(listBook);
            /*
            listBookUC.Show();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "DANH SÁCH HÀNG";
        }

        private void btnListInvoices_Click(object sender, EventArgs e)
		{
			BillImportList billImportList = new BillImportList();
			AddpnControl(billImportList);
			/*
            listBookUC.Hide();
            billImportListUC.Show();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "DANH SÁCH PHIẾU NHẬP";
        }

        private void btnBillImport_Click(object sender, EventArgs e)
		{
			AddBillImport addBillImport = new AddBillImport();
			AddpnControl(addBillImport);
			/*
            listBookUC.Hide();
            billImportListUC.Hide();
            addBillImportUC.Show();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "THÊM PHIẾU NHẬP";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
		{
			Delivery delivery = new Delivery();
			AddpnControl(delivery);
			/*
            listBookUC.Hide();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Show();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "CHUYỂN HÀNG";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
		{
			DeliveryListDetail deliveryListDetail = new DeliveryListDetail();
			AddpnControl(deliveryListDetail);
			/*
            listBookUC.Hide();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Show();
			*/
			txtTitle.Text = "DANH SÁCH PHIẾU CHUYỂN";
        }

        private void btnListBook_Click(object sender, EventArgs e)
		{
			ListBook listBook = new ListBook();
			AddpnControl(listBook);
			/*
            listBookUC.Show();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "DANH SÁCH HÀNG";
        }

        private void btnListInvoice_Click(object sender, EventArgs e)
		{
			BillImportList billImportList = new BillImportList();
			AddpnControl(billImportList);
			/*
            listBookUC.Hide();
            billImportListUC.Show();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "DANH SÁCH PHIẾU NHẬP";
        }

        private void btnAddBillImport_Click(object sender, EventArgs e)
		{
			AddBillImport addBillImport = new AddBillImport();
			AddpnControl(addBillImport);
			/*
            listBookUC.Hide();
            billImportListUC.Hide();
            addBillImportUC.Show();
            deliveryUC.Hide();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "THÊM PHIẾU NHẬP";
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
		{
			Delivery delivery = new Delivery();
			AddpnControl(delivery);
			/*
            listBookUC.Hide();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Show();
            deliveryListDetailUC.Hide();
			*/
			txtTitle.Text = "CHUYỂN HÀNG";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
			DeliveryListDetail deliveryListDetail = new DeliveryListDetail();
			AddpnControl(deliveryListDetail);
			/*
            listBookUC.Hide();
            billImportListUC.Hide();
            addBillImportUC.Hide();
            deliveryUC.Hide();
            deliveryListDetailUC.Show();
            */
			txtTitle.Text = "DANH SÁCH PHIẾU CHUYỂN";
        }
    }
}
