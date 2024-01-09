using BTL.DataProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL.Main.Control
{
    public partial class U_ThuNgan : UserControl
    {
		DataProcesserNghien dataPro = new DataProcesserNghien();
        public static string BillID;
        public static string EmployeeID;
        public static string TotalBill;
        public static string FullName;
        public static string PhoneNumber;
        public U_ThuNgan()
        {
            InitializeComponent();
        }
        public string idOrder()
        {
            string idStart = "HD" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()+"_";
            int id = 0;
            bool check = false;
            string idOders = "";
            DataTable dataTable = new DataTable();
            while (check == false)
            {
                dataTable = dataPro.DataRead("Select BillID from Bill where BillID = '"+idStart+id.ToString()+"'");
                if (dataTable.Rows.Count == 0 )
                {
                    check = true;
                }
                else
                {
                    id++;
                    check = false;
                }
            }
            idOders = idStart + id.ToString();
            return idOders;
        }   
        private void LoadBillDetail()
        {
            DataTable dt = new DataTable();
            dt = dataPro.DataRead("Select TotalBill from Bill where BillID = '" + txtBillID.Text + "'");
            txtTotalBill.Text = dt.Rows[0]["TotalBill"].ToString();
            dt = dataPro.DataRead("Select BookID as 'Mã sách', Price as 'Giá bán', Amount as 'Số lượng', Discount as 'Giảm giá', TotalCost as 'Thành tiền' from BillDetail where BillID = '" + txtBillID.Text + "'");
            dataViewDetail.DataSource = dt;
        }
        public void Reset()
        {
            txtBillID.Text = "";
            DateBill.Text = DateTime.Now.ToString();
            cbEmployeeID.Text = "";
            cbCustomerID.Text = "";
            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBillID.Text = idOrder();
        }

        private void txtEmployeeID_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = dataPro.DataRead("Select EmployeeID from Employee where RoleID = '3'");
            cbEmployeeID.DataSource = dataTable;
            cbEmployeeID.DisplayMember = "EmployeeID";
            cbEmployeeID.ValueMember = "EmployeeID";
        }

        private void cbCustomerID_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = dataPro.DataRead("Select CustomerID from Customer ");
            cbCustomerID.DataSource = dataTable;
            cbCustomerID.DisplayMember = "CustomerID";
            cbCustomerID.ValueMember = "CustomerID";
        }

        private void cbCustomerID_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataPro.DataRead("Select * from Customer where CustomerID = '"+cbCustomerID.Text+"'");
            if(dt.Rows.Count > 0)
            {
                txtFullName.Text = dt.Rows[0]["FullName"].ToString();
                txtPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void cbBookID_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = dataPro.DataRead("Select BookID from Book ");
            cbBookID.DataSource = dataTable;
            cbBookID.DisplayMember = "BookID";
            cbBookID.ValueMember = "BookID";
        }

        private void cbBookID_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataPro.DataRead("Select * from Book where BookID = '" + cbBookID.Text + "'");
            if (dt.Rows.Count > 0)
            {
                txtBookName.Text = dt.Rows[0]["BookName"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();
            }
        }

        private Boolean check (int amount, int store)
        {
            if(amount > store)
                return false;
            else return true;
        }


        private void txt_TextChanged(object sender, EventArgs e)
        {
            int Amout;
            int Discount;
            float Price;
            if (txtDiscount.Text == "")
                Discount = 0;
            else
                Discount = int.Parse(txtDiscount.Text);
            if (txtAmount.Text == "")
                Amout = 0;
            else
                Amout = int.Parse(txtAmount.Text);
            Price = float.Parse(txtPrice.Text);
            txtTotalCost.Text = (Price * Amout - Price * Amout * Discount / 100).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (DataPro.Checked.CheckBill(txtBillID.Text,cbEmployeeID.Text,cbCustomerID.Text) == "bill")
            {
                MessageBox.Show("Bạn chưa có mã hóa đơn !!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (DataPro.Checked.CheckBill(txtBillID.Text, cbEmployeeID.Text, cbCustomerID.Text) == "employee")
            {
                MessageBox.Show("Bạn chưa có mã nhân viên !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataPro.Checked.CheckBill(txtBillID.Text, cbEmployeeID.Text, cbCustomerID.Text) == "customer")
            {
                MessageBox.Show("Bạn chưa có mã khách hàng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dt = dataPro.DataRead("Select StoreAmount from Book where BookID = '" + cbBookID.Text + "'");
            if (check(int.Parse(txtAmount.Text), int.Parse(dt.Rows[0]["StoreAmount"].ToString())) == false)
            {
                MessageBox.Show("Số lượng không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            dt = dataPro.DataRead("Select BillID from Bill where BillID = '"+txtBillID.Text+"'");
            if(dt.Rows.Count == 0)
            {
                dataPro.ChangeData("Insert into Bill (BillID, EmployeeID, CustomerID, DateBill, Status) values (" +
                "'" + txtBillID.Text + "'," +
                "'" + cbEmployeeID.Text + "'," +
                "'" + cbCustomerID.Text + "'," +
                "'" + DateBill.Value.ToString("yyyy-MM-dd") + "'," +
                "'1'"+
                ")");
            }
            if (DataPro.Checked.CheckBillDetail(cbBookID.Text, txtPrice.Text, txtAmount.Text) == "book")
            {
                MessageBox.Show("Bạn chưa có mã sách !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataPro.Checked.CheckBillDetail(cbBookID.Text, txtPrice.Text, txtAmount.Text) == "price")
            {
                MessageBox.Show("Bạn chưa có giá bán !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataPro.Checked.CheckBillDetail(cbBookID.Text, txtPrice.Text, txtAmount.Text) == "amount")
            {
                MessageBox.Show("Bạn chưa có số lượng sách !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dt = dataPro.DataRead("Select BillID, BookID from BillDetail where BillID = '"+txtBillID.Text+ "' and BookID = '"+cbBookID.Text+"'");
            if (dt.Rows.Count  != 0 )
            {
                MessageBox.Show("Đã có mã sách này trong hóa đơn !!");
                return;
            }
            dataPro.ChangeData("Insert into BillDetail (BillID, BookID, Price, Amount, Discount, TotalCost) values (" +
                "'"+txtBillID.Text+"'," +
                "'"+cbBookID.Text+"'," +
                "'"+txtPrice.Text+"'," +
                "'"+txtAmount.Text+"'," +
                "'"+txtDiscount.Text+"'," +
                "'"+txtTotalCost.Text+"'" +
                ")");
            LoadBillDetail();
        }


        private void dataViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbBookID.Text = dataViewDetail.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dataViewDetail.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataViewDetail.CurrentRow.Cells[1].Value.ToString();
            txtTotalCost.Text = dataViewDetail.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataViewDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show(
                "Bạn chắc chắn muốn xóa sản phẩm này ?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                dataPro.ChangeData("Delete from BillDetail where BookID = '" + dataViewDetail.CurrentRow.Cells[0].Value.ToString() +"'");
                MessageBox.Show("Xóa thành công");
                LoadBillDetail();
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            BillID = txtBillID.Text;
            EmployeeID = cbEmployeeID.Text;
            FullName = txtFullName.Text;
            TotalBill = txtTotalBill.Text;
            PhoneNumber = txtPhoneNumber.Text;
            Pay pay = new Pay();
            pay.ShowDialog();
        }


	}
}
