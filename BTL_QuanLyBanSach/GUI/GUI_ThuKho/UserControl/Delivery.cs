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

namespace BaiTapLon
{
    public partial class Delivery : UserControl
    {
        ProcessDataBase processData = new ProcessDataBase();
        public Delivery()
        {
            InitializeComponent();
            txtDeliveryID.Text = DeliveryIDGenerate();
            LoadDeliveryDetailList();
        }

        public void LoadDeliveryDetailList()
        {
            DataTable dt = new DataTable();
            dt = processData.Select("select DeliveryDetail.BookID, BookName,DeliveryAmount ,Author, CategoryName, PublisherName from DeliveryDetail" +
                "\r\nleft join Book on Book.BookID = DeliveryDetail.BookID" +
                "\r\nleft join Category on Book.CategoryID = Category.CategoryID" +
                "\r\nleft join Publisher on Book.PublisherID = Publisher.PublisherID" +
                " where DeliveryID = '" + txtDeliveryID.Text + "'");
            dgvDeliveryDetailList.DataSource = dt;
            dgvDeliveryDetailList.Columns[0].HeaderText = "Mã sách";
            dgvDeliveryDetailList.Columns[1].HeaderText = "Tên sách sách";
            dgvDeliveryDetailList.Columns[2].HeaderText = "Số lượng";
            dgvDeliveryDetailList.Columns[3].HeaderText = "Tác giả";
            dgvDeliveryDetailList.Columns[4].HeaderText = "Thể loại";
            dgvDeliveryDetailList.Columns[5].HeaderText = "Nhà xuất bản";
           
        }

        public void ClearDeliveryDetailList()
        {
            DataTable dt = new DataTable();
            dt = processData.Select("select DeliveryID, DeliveryDetail.BookID, BookName,DeliveryAmount ,Author, CategoryName, PublisherName from DeliveryDetail" +
                "\r\nleft join Book on Book.BookID = DeliveryDetail.BookID" +
                "\r\nleft join Category on Book.CategoryID = Category.CategoryID" +
                "\r\nleft join Publisher on Book.PublisherID = Publisher.PublisherName" +
                " where DeliveryID = ''" );
            dgvDeliveryDetailList.DataSource = dt;

        }

        public string DeliveryIDGenerate()
        {
            string idStart = "PC" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()+"_";
            int id = 0;
            bool check = false;
            string idOders = "";
            DataTable dataTable = new DataTable();
            while (check == false)
            {
                dataTable = processData.Select("Select DeliveryID from Delivery where DeliveryID = '"+idStart+id.ToString()+"'");
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

        public bool check()
        {
            if (txtDeliveryAmount.Text != "" && cbxBookID.Text != "" && cbxEmployee.Text != "")
            {
                return true;
            }
            else return false;
        }

        private void cbxEmployee_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = processData.Select("Select EmployeeID, FullName from Employee where RoleID = '2'");
            cbxEmployee.DataSource = dataTable;
            cbxEmployee.DisplayMember = "FullName";
            cbxEmployee.ValueMember = "EmployeeID";
        }

        private void cbxBookID_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = processData.Select("select BookID, BookName from Book where StockAmount > 0");
            cbxBookID.DataSource = dt;
            cbxBookID.DisplayMember = "BookName";
            cbxBookID.ValueMember = "BookID";
        }

        public void Clear()
        {
            cbxEmployee.Text = "";
            cbxBookID.Text = "";
            txtDeliveryAmount.Text = "";
            ClearDeliveryDetailList();
        }

        private void dgvDeliveryDetailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show(
                "Bạn chắc chắn muốn xóa sản phẩm này ?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.Yes)
            {
                string sql = "Select StockAmount from Book where BookID = '" + cbxBookID.SelectedValue + "'";
                int slkho = processData.SqlReader<int>(sql, "StockAmount");
                string sql1 = "select StoreAmount from Book where BookID = '" + cbxBookID.SelectedValue + "'";
                int slstore = processData.SqlReader<int>(sql1, "StoreAmount");
                DataTable data = new DataTable();
                int slc = int.Parse(dgvDeliveryDetailList.CurrentRow.Cells[3].Value.ToString());
                //Xóa chi tiết phiếu nhập
                processData.Update("Delete from DeliveryDetail where BookID = '" +dgvDeliveryDetailList.CurrentRow.Cells[1].Value.ToString() +"' and DeliveryID = '" + txtDeliveryID.Text + "'");
                /*data = processData.Select("Select * from Book where BookID = '" + dgvDeliveryDetailList.CurrentRow.Cells[0].Value.ToString() + "'");
                int slkho = int.Parse(data.Rows[0][8].ToString());*/
                //Cập nhật số lượng
                processData.Update("update Book set StockAmount = " +(slkho + slc)
                    + " where BookID = '" + dgvDeliveryDetailList.CurrentRow.Cells[1].Value.ToString() + "'");
                processData.Update("update Book set StoreAmount = " +(slstore - slc)
                    + " where BookID = '" + dgvDeliveryDetailList.CurrentRow.Cells[1].Value.ToString() + "'");
                MessageBox.Show("Xóa thành công");
                LoadDeliveryDetailList();


            }
        }

        private void gunabtnAdd_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int slchuyen = int.Parse(txtDeliveryAmount.Text);
                DataTable dt = new DataTable();
                string sql = "Select StockAmount from Book where BookID = '" + cbxBookID.SelectedValue + "'";
                int slkho = processData.SqlReader<int>(sql, "StockAmount");
                string sql1 = "select StoreAmount from Book where BookID = '" + cbxBookID.SelectedValue + "'";
                int slstore = processData.SqlReader<int>(sql1, "StoreAmount");
                dt = processData.Select("Select DeliveryID from Delivery where DeliveryID = '" + txtDeliveryID.Text + "'");
                if (slchuyen > slkho)
                {
                    MessageBox.Show("Số lượng sách trong kho không đủ !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (dt.Rows.Count == 0)
                    {
                        //Thêm phiếu chuyển
                        DataTable dataTable = new DataTable();
                        processData.Update("Insert into Delivery (DeliveryID, EmployeeID, DateDelivery) values (" +
                        "'" + txtDeliveryID.Text + "'," +
                        "'" + cbxEmployee.SelectedValue + "'," +
                        "'" + dtpDeliveryDate.Value.ToString("yyyy-MM-dd") + "')");
                        //Thêm chi tiết phiếu chuyển
                        DataTable data = new DataTable();
                        data = processData.Select("Select BookID from DeliveryDetail where DeliveryID = '" + txtDeliveryID.Text + "'");
                        if (data.Rows.Count == 0)
                        {
                            processData.Update("Insert into DeliveryDetail (DeliveryID, BookID, DeliveryAmount) values (" +
                            "'" + txtDeliveryID.Text + "'," +
                            "'" + cbxBookID.SelectedValue + "'," +
                            "'" + txtDeliveryAmount.Text + "')");
                            //Cập nhật số lượng

                            processData.Update("Update Book set StoreAmount = " + (slstore + slchuyen) + " where BookID = '" + cbxBookID.SelectedValue + "'");
                            processData.Update("Update Book set StockAmount = " + (slkho - slchuyen) + " where BookID = '" + cbxBookID.SelectedValue + "'");
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại sách này trong phiếu chuyển");
                            return;
                        }
                        LoadDeliveryDetailList();
                    }
                    else
                    {
                        //Thêm chi tiết phiếu chuyển
                        processData.Update("Insert into DeliveryDetail (DeliveryID, BookID, DeliveryAmount) values (" +
                            "'" + txtDeliveryID.Text + "'," +
                            "'" + cbxBookID.SelectedValue + "'," +
                            "'" + txtDeliveryAmount.Text + "')");
                        //Cập nhật số lượng
                        processData.Update("Update Book set StoreAmount = " + (slstore + slchuyen) + " where BookID = '" + cbxBookID.SelectedValue + "'");
                        processData.Update("Update Book set StockAmount = " + (slkho - slchuyen) + " where BookID = '" + cbxBookID.SelectedValue + "'");
                        LoadDeliveryDetailList();
                    }

                }
            }
            

        }

        private void gunabtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Bạn chắc chắn muốn hủy phiếu chuyển này ?",
               "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               ) == DialogResult.Yes)
            {
                string sql = "Select StockAmount from Book where BookID = '" + cbxBookID.SelectedValue + "'";
                int slkho = processData.SqlReader<int>(sql, "StockAmount");
                string sql1 = "select StoreAmount from Book where BookID = '" + cbxBookID.SelectedValue + "'";
                int slstore = processData.SqlReader<int>(sql1, "StoreAmount");
                int slchuyen = int.Parse(txtDeliveryAmount.Text);
                DataTable dt = new DataTable();
                dt = processData.Select("select DeliveryID from DeliveryDetail where DeliveryID = '" + txtDeliveryID.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    //Cập nhật số lượng
                    List<string> list = new List<string>();
                    list = processData.GetBookID("Select BookID from DeliveryDetail where DeliveryID = '" + txtDeliveryID.Text +"'");
                    foreach (string item in list)
                    {
                        processData.Update("Update Book set StoreAmount = " + (slstore - slchuyen) + " where BookID = '" + item + "'");
                        processData.Update("Update Book set StockAmount = " + (slkho + slchuyen) + " where BookID = '" + item + "'");
                    }

                    //Xóa DeliveryDetail
                    processData.Update("Delete DeliveryDetail where DeliveryID = '" + txtDeliveryID.Text + "'");
                    //Xóa Delivery
                    processData.Update("Delete Delivery where DeliveryID = '" + txtDeliveryID.Text + "'");
                }
                else
                {
                    processData.Update("Delete Delivery where DeliveryID = '" + txtDeliveryID.Text + "'");
                }
                MessageBox.Show("Xóa thành công");
                Clear();
                return;
            }
        }

        private void gunabtnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã chuyển hàng");
            txtDeliveryID.Text = DeliveryIDGenerate();
            Clear();
        }
    }
}
