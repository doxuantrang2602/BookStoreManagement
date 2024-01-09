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
    public partial class DeliveryListDetail : UserControl
    {
        ProcessDataBase processData = new ProcessDataBase();
        Color buttonColor = Color.FromArgb(35, 40, 45);
        public DeliveryListDetail()
        {
            InitializeComponent();
            displayDeliveryID("Select * from Delivery");
            
        }

        public void displayDeliveryID(string sql)
        {
            DataTable dt = new DataTable();
            dt = processData.Select(sql);
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                Guna2Button button = new Guna2Button();

                button.Width = 200;
                button.Height = 30;
                button.FillColor = buttonColor;
                button.PressedColor = Color.FromArgb(255, 128, 128);
                button.Text = dt.Rows[i][0].ToString();
                button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                button.Image = null;
                button.Name = "btn"+dt.Rows[i][0].ToString();
                button.Click += new System.EventHandler(this.btn_DeliveryID_click);
                panelDeliveryListID.Controls.Add(button);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btn_DeliveryID_click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            DataTable data = new DataTable();
            data = processData.Select("select DeliveryDetail.BookID, BookName, DateDelivery ,DeliveryAmount ,Author, CategoryName, PublisherName from DeliveryDetail" +
                "\r\nleft join Book on Book.BookID = DeliveryDetail.BookID" +
                "\r\nleft join Category on Book.CategoryID = Category.CategoryID" +
                "\r\nleft join Publisher on Book.PublisherID = Publisher.PublisherID" +
                "\r\nleft join Delivery on Delivery.DeliveryID = DeliveryDetail.DeliveryID"+
                "\r\nwhere Delivery.DeliveryID = '" + button.Text + "'");
            dgvDeliveryDetailList.DataSource = data;
            txtDeliveryID.Text = button.Text;
            DateTime date = new DateTime();
            string sql = "Select DateDelivery from Delivery where DeliveryID = '" + button.Text +"'";
            date = processData.SqlReader<DateTime>(sql,"DateDelivery");
            txtBillImportDate.Text = date.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            dt = processData.Select("select FullName from Delivery" +
                "\r\nleft join Employee on Employee.EmployeeID = Delivery.EmployeeID where DeliveryID = '" + button.Text + "'");
            string sql1 = "select FullName from Delivery\r\nleft join Employee on Employee.EmployeeID = Delivery.EmployeeID where DeliveryID = '" + button.Text +"'";
            txtEmployeeName.Text = processData.SqlReader<string>(sql1, "FullName");
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control control in panelDeliveryListID.Controls)
                {
                    if(control.Name != "panel3")
                    {
                        control.Visible = false;
                    }
                }
                //*/displayDeliveryID("Select * from Delivery where DeliveryID = ''");
                DataTable dt = new DataTable();
                dt = processData.Select("select DeliveryID from Delivery where DeliveryID = '" + txtSearch.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    Guna2Button button = new Guna2Button();
                    button.Width = 200;
                    button.Height = 30;
                    button.FillColor = buttonColor;
                    button.PressedColor = Color.FromArgb(255, 128, 128);
                    button.Text = txtSearch.Text;
                    button.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    button.Image = null;
                    button.Name = "btn"+txtSearch.ToString();
                    button.Click += new System.EventHandler(this.btn_DeliveryID_click);
                    panelDeliveryListID.Controls.Add(button);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã phiếu chuyển");
                    return;
                }

            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            foreach (Control control in panelDeliveryListID.Controls)
            {
                if (control.Name != "panel3")
                {
                    control.Visible = false;
                }
            }
            displayDeliveryID("Select * from Delivery");
        }
    }
}
