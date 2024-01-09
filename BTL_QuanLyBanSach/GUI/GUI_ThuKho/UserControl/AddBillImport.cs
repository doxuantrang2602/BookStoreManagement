using BaiTapLon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BaiTapLon
{
    public partial class AddBillImport : UserControl
    {
        ProcessDataBase processData = new ProcessDataBase();
        public AddBillImport()
        {
            InitializeComponent();
            txtBillImportID.Text = BillImportIDGenerate();
            enableTexBox(false);
            LoadBillImportDetail();
        }

        public void LoadBillImportDetail()
        {
            DataTable dt = new DataTable();
            dt = processData.Select("Select TotalBillImport from BillImport where BillImportID = '" + txtBillImportID.Text + "'");
            if (dt.Rows.Count !=0)
            {
                txtToltalCost.Text = dt.Rows[0][0].ToString();
            }
            else txtToltalCost.Text = "";
            dt = processData.Select("select BillImportDetail.BookID, BookName, Author, CategoryName, PublisherName, PublishYear, BillImportDetail.ImportPrice, ImportAmount from Book" +
                "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID" +
                "\r\njoin BillImportDetail on BillImportDetail.BookID = Book.BookID"+"" +
                " where BillImportID = '" + txtBillImportID.Text + "'");
            dgvBillImportDetail.DataSource = dt;
            dgvBillImportDetail.Columns[0].HeaderText = "Mã sách";
            dgvBillImportDetail.Columns[1].HeaderText = "Tên sách";
            dgvBillImportDetail.Columns[2].HeaderText = "Tác giả";
            dgvBillImportDetail.Columns[3].HeaderText = "Thể loại";
            dgvBillImportDetail.Columns[4].HeaderText = "Nhà xuất bản";
            dgvBillImportDetail.Columns[5].HeaderText = "Năm xuất bản";
            dgvBillImportDetail.Columns[6].HeaderText = "Giá nhập";
            dgvBillImportDetail.Columns[7].HeaderText = "Số lượng nhập";
        }

        public void enableTexBox(bool check)
        {
            if (check)
            {
                txtBookName.Enabled = check;
                txtAuthor.Enabled = check;
                txtYearPublished.Enabled = check;
                cbxCategory.Enabled = check;
                cbxPublisher.Enabled = check;
            }
            else
            {
                txtBookName.Enabled = false;
                txtAuthor.Enabled = false;
                txtYearPublished.Enabled = false;
                cbxCategory.Enabled = false;
                cbxPublisher.Enabled = false;
            }
        }

        private void btnAddBillImport_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = processData.Select("select BillImportID from BillImport where BillImportID = '" + txtBillImportID.Text +"'");
            
            if(!check())
            {
                enableTexBox(true);
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (data.Rows.Count == 0)
                {
                    DataTable dataTable = new DataTable();
                    processData.Update("Insert into BillImport (BillImportID, EmployeeID, DateImport,VendorID ,TotalBillImport) values (" +
                    "'" + txtBillImportID.Text + "'," +
                    "'" + cbxEmployee.SelectedValue + "'," +
                    "'" + dtpBillImportDate.Value.ToString("yyyy-MM-dd") + "'," +
                    "'" + cbxVendorName.SelectedValue + "'," +
                    "'" + txtToltalCost.Text + "')");
                    LoadBillImportDetail();
                }
                data = processData.Select("Select BookID from Book where BookID = '" + txtBookID.Text+"'");
                if(data.Rows.Count == 0)
                {
                    processData.Update("Insert into Book (BookID, BookName, Author,CategoryID, ImportPrice,StockAmount,PublisherID,PublishYear) values (" +
                        "'" + txtBookID.Text +"'," +
                        "'" + txtBookName.Text + "'," +
                        "'" + txtAuthor.Text + "'," +
                        "'" + cbxCategory.SelectedValue + "'," +
                        "'" + txtImportPrice.Text + "'," +
                        "'" + txtImportAmount.Text + "'," +
                        "'" + cbxPublisher.SelectedValue + "'," +
                        "'" + txtYearPublished.Text +"')");
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = processData.Select("Select StockAmount from Book where BookID = '" + txtBookID.Text + "'");
                    int amount = int.Parse(dt.Rows[0][0].ToString());
                    processData.Update("Update Book set StockAmount = " + (amount + int.Parse(txtImportAmount.Text)) + 
                        " where BookID = '" + txtBookID.Text +"'");
                }
                data = processData.Select("Select BookID from Book where BookID = '" + txtBookID.Text+"'");
                if(data.Rows.Count != 0)
                {
                    processData.Update("insert into BillImportDetail (BillImportID,BookID,ImportPrice,ImportAmount) values (" + "" +
                        "'" + txtBillImportID.Text + "'," +
                        "'" + txtBookID.Text + "'," +
                        "'" + txtImportPrice.Text +"'," +
                        "'" + txtImportAmount.Text +"')");
                }
            }
            LoadBillImportDetail();
        }

        public string BillImportIDGenerate()
        {
            string idStart = "HDN" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()+"_";
            int id = 0;
            bool check = false;
            string idOders = "";
            DataTable dataTable = new DataTable();
            while (check == false)
            {
                dataTable = processData.Select("Select BillImportID from BillImport where BillImportID = '"+idStart+id.ToString()+"'");
                if (dataTable.Rows.Count == 0)
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

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCategory_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = processData.Select("Select CategoryID, CategoryName from Category");
            cbxCategory.DataSource = dataTable;
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";
        }

       
        private void cbxCategory_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                dt = processData.Select("Select * from Book where BookID = '" + txtBookID.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    enableTexBox(true);
                    MessageBox.Show("Bạn chưa có đầu sách này, hãy nhập thông tin sách", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    txtBookName.Text = dt.Rows[0][1].ToString();
                    txtAuthor.Text = dt.Rows[0][2].ToString();
                    cbxCategory.Text = dt.Rows[0][3].ToString();
                    cbxPublisher.Text = dt.Rows[0][4].ToString();
                    txtYearPublished.Text = dt.Rows[0][9].ToString();
                }
            }
        }

        private void dgvBillImportDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show(
                "Bạn chắc chắn muốn xóa sản phẩm này ?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                DataTable data = new DataTable();
                int sln = int.Parse(dgvBillImportDetail.CurrentRow.Cells[7].Value.ToString());
                //Xóa chi tiết phiếu nhập
                processData.Update("Delete from BillImportDetail where BookID = '" +dgvBillImportDetail.CurrentRow.Cells[0].Value.ToString() +"' and BillImportID = '" + txtBillImportID.Text + "'");
                data = processData.Select("Select * from Book where BookID = '" + dgvBillImportDetail.CurrentRow.Cells[0].Value.ToString() + "'");
                int sl = int.Parse(data.Rows[0][8].ToString());
                //Cập nhật số lượng
                processData.Update("update Book set StockAmount = " +(sl - sln)
                    + " where BookID = '" + dgvBillImportDetail.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Xóa thành công");
                LoadBillImportDetail();
               
                
            }
        }

        public void Clear()
        {
            txtBillImportID.Text = BillImportIDGenerate();
            txtBookID.Text = "";
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtImportAmount.Text = "";
            txtImportPrice.Text = "";
            txtToltalCost.Text = "";
            txtYearPublished.Text = "";
            cbxCategory.Text = "";
            cbxPublisher.Text = "";
            cbxEmployee.Text = "";
            cbxVendorName.Text = "";
            LoadBillImportDetail();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Clear();
            txtBillImportID.Text = BillImportIDGenerate();
            MessageBox.Show("Đã lưu thành công");
            
        }

        private bool check()
        {
            if(txtBookName.Text != "" && txtAuthor.Text != "" && txtBookID.Text != "" 
                && txtImportAmount.Text != "" && txtImportPrice.Text != "" && txtYearPublished.Text != "" 
                && cbxCategory.Text != "" && cbxPublisher.Text != "" && cbxEmployee.Text != "" && cbxVendorName.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cbxEmployee_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = processData.Select("Select EmployeeID, FullName from Employee where RoleID = '2'");
            cbxEmployee.DataSource = dataTable;
            cbxEmployee.DisplayMember = "FullName";
            cbxEmployee.ValueMember = "EmployeeID";
        }

        private void dgvBillImportDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Bạn chắc chắn muốn hủy hóa đơn này ?",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               ) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt = processData.Select("Select * from BillImportDetail where BillImportID = '" + txtBillImportID.Text + "'");
                if(dt.Rows.Count > 0) 
                {
                    //cập nhật số lượng sách
                    List<string> list = new List<string>();
                    list = processData.GetBookID("Select BookID from BillImportDetail where BillImportID = '" + txtBillImportID.Text +"'");
                    foreach(string item in list)
                    {
                        string sql = "Select ImportAmount from BillImportDetail where BookID = '" + item + "' and BillImportID = '" + txtBillImportID.Text + "'";
                        int sl = processData.SqlReader<int>(sql, "ImportAmount");
                        //string s = "StockAmount - " + sl.ToString();
                        processData.Update("Update Book set StockAmount = StockAmount - " + sl.ToString() + " where BookID = '" + item + "'"); ;
                    }
                    //Xóa chi tiết hóa đơn nhập
                    processData.Update("delete BillImportDetail where BillImportID = '" + txtBillImportID.Text + "'");
                    //Xóa hóa đơn nhập
                    processData.Update("delete BillImport where BillImportID = '" + txtBillImportID.Text + "'");
                }
                MessageBox.Show("Hủy thành công");
                Clear();
            }
        }

        private void cbxPublisher_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = processData.Select("Select PublisherID, PublisherName from Publisher");
            cbxPublisher.DataSource = dataTable;
            cbxPublisher.DisplayMember = "PublisherName";
            cbxPublisher.ValueMember = "PublisherID";
        }

        private void cbxVendorName_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = processData.Select("Select VendorID, VendorName from Vendor");
            cbxVendorName.DataSource = dataTable;
            cbxVendorName.DisplayMember = "VendorName";
            cbxVendorName.ValueMember = "VendorID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = processData.Select("select BillImportID from BillImport where BillImportID = '" + txtBillImportID.Text +"'");

            if (!check())
            {
                enableTexBox(true);
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (data.Rows.Count == 0)
                {
                    DataTable dataTable = new DataTable();
                    processData.Update("Insert into BillImport (BillImportID, EmployeeID, DateImport,VendorID ,TotalBillImport) values (" +
                    "'" + txtBillImportID.Text + "'," +
                    "'" + cbxEmployee.SelectedValue + "'," +
                    "'" + dtpBillImportDate.Value.ToString("yyyy-MM-dd") + "'," +
                    "'" + cbxVendorName.SelectedValue + "'," +
                    "'" + txtToltalCost.Text + "')");
                    LoadBillImportDetail();
                }
                data = processData.Select("Select BookID from Book where BookID = '" + txtBookID.Text+"'");
                if (data.Rows.Count == 0)
                {
                    processData.Update("Insert into Book (BookID, BookName, Author,CategoryID, ImportPrice,StockAmount,PublisherID,PublishYear) values (" +
                        "'" + txtBookID.Text +"'," +
                        "'" + txtBookName.Text + "'," +
                        "'" + txtAuthor.Text + "'," +
                        "'" + cbxCategory.SelectedValue + "'," +
                        "'" + txtImportPrice.Text + "'," +
                        "'" + txtImportAmount.Text + "'," +
                        "'" + cbxPublisher.SelectedValue + "'," +
                        "'" + txtYearPublished.Text +"')");
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = processData.Select("Select StockAmount from Book where BookID = '" + txtBookID.Text + "'");
                    int amount = int.Parse(dt.Rows[0][0].ToString());
                    processData.Update("Update Book set StockAmount = " + (amount + int.Parse(txtImportAmount.Text)) +
                        " where BookID = '" + txtBookID.Text +"'");
                }
                data = processData.Select("Select BookID from Book where BookID = '" + txtBookID.Text+"'");
                if (data.Rows.Count != 0)
                {
                    processData.Update("insert into BillImportDetail (BillImportID,BookID,ImportPrice,ImportAmount) values (" + "" +
                        "'" + txtBillImportID.Text + "'," +
                        "'" + txtBookID.Text + "'," +
                        "'" + txtImportPrice.Text +"'," +
                        "'" + txtImportAmount.Text +"')");
                }
            }
            LoadBillImportDetail();
        }

        private void gunabtnFinish_Click(object sender, EventArgs e)
        {
            Clear();
            txtBillImportID.Text = BillImportIDGenerate();
            MessageBox.Show("Đã lưu thành công");
        }

        private void gunabtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Bạn chắc chắn muốn hủy hóa đơn này ?",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               ) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt = processData.Select("Select * from BillImportDetail where BillImportID = '" + txtBillImportID.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    //cập nhật số lượng sách
                    List<string> list = new List<string>();
                    list = processData.GetBookID("Select BookID from BillImportDetail where BillImportID = '" + txtBillImportID.Text +"'");
                    foreach (string item in list)
                    {
                        string sql = "Select ImportAmount from BillImportDetail where BookID = '" + item + "' and BillImportID = '" + txtBillImportID.Text + "'";
                        int sl = processData.SqlReader<int>(sql, "ImportAmount");
                        //string s = "StockAmount - " + sl.ToString();
                        processData.Update("Update Book set StockAmount = StockAmount - " + sl.ToString() + " where BookID = '" + item + "'"); ;
                    }
                    //Xóa chi tiết hóa đơn nhập
                    processData.Update("delete BillImportDetail where BillImportID = '" + txtBillImportID.Text + "'");
                    //Xóa hóa đơn nhập
                    processData.Update("delete BillImport where BillImportID = '" + txtBillImportID.Text + "'");
                }
                MessageBox.Show("Hủy thành công");
                Clear();
            }
        }
    }
}
