using BaiTapLon.Classes;
using Guna.UI2.WinForms;
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
    public partial class BillImportList : UserControl
    {
        ProcessDataBase processData = new ProcessDataBase();
        Color buttonColor = Color.FromArgb(35, 40, 45);
        Color hoverColor = Color.FromArgb(255, 128, 128);
        public BillImportList()
        {
            InitializeComponent();
            displayBillImportID("Select * from BillImport");
            
        }

        public void displayBillImportID(string sql)
        {
            DataTable dt = new DataTable();
            dt = processData.Select(sql);
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                Guna2Button button = new Guna2Button();

                button.Width = 200;
                button.Height = 30;
                button.FillColor = buttonColor;
                button.PressedColor = hoverColor;
                button.Text = dt.Rows[i][0].ToString();
                button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                button.Image = null;
                button.Name = "btn"+dt.Rows[i][0].ToString();
                button.Click += new System.EventHandler(this.btn_BillID_click);
                panelBillImportID.Controls.Add(button);
            }
        }

        private void txtBillImportID_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_BillID_click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            DataTable data = new DataTable();
            data = processData.Select("select BillImportID, FullName, DateImport, VendorName from BillImport" +
                "\r\nleft join Employee on Employee.EmployeeID = BillImport.EmployeeID" +
                "\r\nleft join Vendor on Vendor.VendorID = BillImport.VendorID" +
                                    " where BillImportID = '"+button.Text+"'");
            //txtBillImportID.Text = data.Rows[0][2].ToString();
            //txtEmployeeName.Text = data.Rows[0][0].ToString();
            txtBillImportDate.Text = data.Rows[0][2].ToString();
            txtEmployeeName.Text = data.Rows[0][1].ToString();
            txtVendorName.Text = data.Rows[0][3].ToString();
            txtBillImportID.Text = button.Text;
            data = processData.Select("Select BookID, ImportPrice, ImportAmount from BillImportDetail where BillImportID = '"+button.Text+"'");
            dgvBillImportList.DataSource = data;
            data = processData.Select("Select TotalBillImport from BillImport where BillImportID = '" + button.Text+"'");
            txtTotalBillImport.Text = data.Rows[0][0].ToString();
        }

        private void txtSearchBillImportID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control control in panelBillImportID.Controls)
                {
                    if (control.Name != "panel3")
                    {
                        control.Visible = false;
                    }
                }
                //*/displayDeliveryID("Select * from Delivery where DeliveryID = ''");
                DataTable dt = new DataTable();
                dt = processData.Select("select BillImportID from BillImport where BillImportID = '" + txtSearchBillImportID.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    Guna2Button button = new Guna2Button();
                    button.Width = 200;
                    button.Height = 30;
                    button.FillColor = buttonColor;
                    button.PressedColor = hoverColor;
                    button.Text = txtSearchBillImportID.Text;
                    button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    button.Image = null;
                    button.Name = "btn"+txtSearchBillImportID.ToString();
                    button.Click += new System.EventHandler(this.btn_BillID_click);
                    panelBillImportID.Controls.Add(button);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu nhập");
                    return;
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchBillImportID.Text = "";
            foreach (Control control in panelBillImportID.Controls)
            {
                if (control.Name != "panel3")
                {
                    control.Visible = false;
                }
            }
            displayBillImportID("Select * from BillImport");
        }

        private void txtSearchBillImportID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
