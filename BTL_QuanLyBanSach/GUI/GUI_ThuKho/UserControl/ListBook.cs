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
    public partial class ListBook : UserControl
    {
        ProcessDataBase processData = new ProcessDataBase();
        public ListBook()
        {
            InitializeComponent();
            processData.OpenConnect();
            DataTable dataTable = processData
                .Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID" +
                "\r\nwhere StockAmount > 0");
           
            dgvlistBook.DataSource = dataTable;
            dgvlistBook.Columns[0].HeaderText = "ID Sách";
            dgvlistBook.Columns[1].HeaderText = "Tên sách";
            dgvlistBook.Columns[2].HeaderText = "Tác giả";
            dgvlistBook.Columns[3].HeaderText = "Thể loại";
            dgvlistBook.Columns[4].HeaderText = "Năm xuất bản";
            dgvlistBook.Columns[5].HeaderText = "Nhà xuất bản";
            dgvlistBook.Columns[6].HeaderText = "Tiền nhập";
            dgvlistBook.Columns[7].HeaderText = "Số lượng";

            int TotalBookAmount,BookAmount;
            string sql1 = "select SUM(StockAmount) as TotalBookAmount from Book";
            string sql2 = "select count(BookID) as TotalBook from Book";
            BookAmount = processData.SqlReader<int>(sql2, "TotalBook");
            TotalBookAmount = processData.SqlReader<int>(sql1, "TotalBookAmount");
            totalBookAmount.Text = TotalBookAmount.ToString();
            totalBook.Text = BookAmount.ToString();
        }

        private void dgvlistBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnTK_Click(object sender, EventArgs e)
        {
            processData.OpenConnect();
            if (txtBookID.Text == "" && txtMinPrice.Text == "" && txtMaxPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }

            else if (txtBookID.Text != "" && txtMinPrice.Text == "" && txtMaxPrice.Text == "")
            {
                //Chỉ có mã sản phẩm
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID where BookID = '" + txtBookID.Text + "'");
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào có mã " + txtBookID.Text);
                }
                else dgvlistBook.DataSource = dataTable;
            }
            else if (txtBookID.Text != "" && txtMinPrice.Text != "" && txtMaxPrice.Text == "")
            {
                //Có mã sp và giá min
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID where BookID = '" + txtBookID.Text + "'" +" and ImportPrice >= " + int.Parse(txtMinPrice.Text));
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm thỏa mãn");
                }
                else dgvlistBook.DataSource = dataTable;
            }
            else if (txtBookID.Text != "" && txtMinPrice.Text == "" && txtMaxPrice.Text != "")
            {
                //Có mã sp và giá max
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID " +
                    "where BookID = '" + txtBookID.Text + "'" +" and ImportPrice <= " + int.Parse(txtMaxPrice.Text));
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm thỏa mãn");
                }
                else dgvlistBook.DataSource = dataTable;
            }
            else if (txtBookID.Text == "" && txtMinPrice.Text != "" && txtMaxPrice.Text == "")
            {
                //Chỉ có giá min
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID " +
                    "where ImportPrice >= " + int.Parse(txtMinPrice.Text));
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm thỏa mãn");
                }
                else dgvlistBook.DataSource = dataTable;
            }
            else if (txtBookID.Text == "" && txtMinPrice.Text == "" && txtMaxPrice.Text != "")
            {
                //Chỉ có giá max
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID " +
                    "where ImportPrice <= " + int.Parse(txtMaxPrice.Text));
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm thỏa mãn");
                }
                else dgvlistBook.DataSource = dataTable;
            }
            else if (txtBookID.Text == "" && txtMinPrice.Text != "" && txtMaxPrice.Text != "")
            {
                //Có giá min và max
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID " +
                    "where ImportPrice <= " + int.Parse(txtMaxPrice.Text) + " and ImportPrice >= " + int.Parse(txtMinPrice.Text));
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm thỏa mãn");
                }
                else dgvlistBook.DataSource = dataTable;
            }
            else
            {
                //Có cả 3
                DataTable dataTable = processData.Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                    "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                    "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID " +
                    "where BookID = '" + txtBookID.Text + "'" + " and ImportPrice < \" + int.Parse(txtMaxPrice.Text)");
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm thỏa mãn");
                }
            }
            processData.CloseConnect();
        }

        private void gunabtnReset_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtMinPrice.Text = "";
            txtMaxPrice.Text = "";
            DataTable dataTable = processData
                .Select("select BookID, BookName, Author, CategoryName,PublishYear ,PublisherName, ImportPrice, StockAmount from Book" +
                "\r\nleft join Category on Category.CategoryID = Book.CategoryID" +
                "\r\nleft join Publisher on Publisher.PublisherID = Book.PublisherID" +
                "\r\nwhere StockAmount > 0");

            dgvlistBook.DataSource = dataTable;
            dgvlistBook.Columns[0].HeaderText = "ID Sách";
            dgvlistBook.Columns[1].HeaderText = "Tên sách";
            dgvlistBook.Columns[2].HeaderText = "Tác giả";
            dgvlistBook.Columns[3].HeaderText = "Thể loại";
            dgvlistBook.Columns[4].HeaderText = "Năm xuất bản";
            dgvlistBook.Columns[5].HeaderText = "Nhà xuất bản";
            dgvlistBook.Columns[6].HeaderText = "Tiền nhập";
            dgvlistBook.Columns[7].HeaderText = "Số lượng";
        }
    }
}
