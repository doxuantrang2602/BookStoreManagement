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

namespace BTL.Main.Control
{
    public partial class U_Search : UserControl
    {
		DataProcesserNghien dataPro = new DataProcesserNghien();

		public U_Search()
        {
            InitializeComponent();
        }

		private void cbCategory_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable = dataPro.DataRead("Select CategoryName from Category ");
			cbCategory.DataSource = dataTable;
			cbCategory.DisplayMember = "CategoryName";
			cbCategory.ValueMember = "CategoryName";
		}

		private void cbPublisher_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable = dataPro.DataRead("Select PublisherName from Publisher ");
			cbPublisher.DataSource = dataTable;
			cbPublisher.DisplayMember = "PublisherName";
			cbPublisher.ValueMember = "PublisherName";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable = dataPro.DataRead("Select Book.BookID as 'Mã sách',Book.BookName as 'Tên sách',Book.Author as 'Tác giả',Publisher.PublisherName as 'Nhà sản xuất',Category.CategoryName as 'Thể loại' " +
										"from Book inner join Publisher on Book.PublisherId = Publisher.PublisherID " +
										"inner join Category on Book.CategoryID = Category.CategoryID " +
										"where PublisherName = N'"+cbPublisher.Text+ "' or CategoryName = N'"+cbCategory.Text+"'");
			dataViewBook.DataSource = dataTable;
		}

		private void dataViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				dataTable = dataPro.DataRead("Select Price, StoreAmount, StockAmount, PublishYear, Description from Book where BookID = '" + dataViewBook.CurrentRow.Cells[0].Value.ToString() + "'");
				txtPrice.Text = dataTable.Rows[0]["Price"].ToString();
				txtStoreAmount.Text = dataTable.Rows[0]["StoreAmount"].ToString();
				txtStockAmount.Text = dataTable.Rows[0]["StockAmount"].ToString();
				txtPublishYear.Text = dataTable.Rows[0]["PublishYear"].ToString();
				txtDescription.Text = dataTable.Rows[0]["Description"].ToString();
			}
			catch { }
		}
	}
}
