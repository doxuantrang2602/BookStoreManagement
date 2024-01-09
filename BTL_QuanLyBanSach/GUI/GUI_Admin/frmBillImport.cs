using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using BTL_QuanLyBanSach.DAO;
using BTL_QuanLyBanSach.DTO;
using Guna.UI2.WinForms;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    public partial class frmBillImport : Form
    {
        DataProcesserTrang dtBase = new DataProcesserTrang();
        Dictionary<int, string> StatusVendor = new Dictionary<int, string>()
        {
            {0, "Ngừng hợp tác" },
            {1,"Đang hợp tác" }
        };
        public frmBillImport()
        {
            InitializeComponent();
            loadVendor();
            loadTableVendor();
			loadBillImport();
			dtgv_NhaCungCap.ReadOnly = true;
			foreach (DataGridViewColumn column in dtgv_NhaCungCap.Columns)
			{
				column.ReadOnly = true;
			}
			cb_TrangThai.DataSource = new BindingSource(StatusVendor, null);
			cb_TrangThai.DisplayMember = "Value";
			cb_TrangThai.ValueMember = "Key";
			cb_TrangThai.SelectedIndex = -1;

			dtgv_HoaDonNhap.ReadOnly = true;
			foreach (DataGridViewColumn column in dtgv_HoaDonNhap.Columns)
			{
				column.ReadOnly = true;
			}
			dtgv_ChiTietHDN.ReadOnly = true;
			foreach (DataGridViewColumn column in dtgv_ChiTietHDN.Columns)
			{
				column.ReadOnly = true;
			}

		}
		public void loadBillImport()
		{
			string sqlSelect = "Select BillImportID, BillImport.EmployeeID, Employee.FullName, " +
				"DateImport, Vendor.VendorName, TotalBillImport " +
				"from BillImport " +
				"inner join Employee on Employee.EmployeeID = BillImport.EmployeeID " +
				"inner join Vendor on Vendor.VendorID = BillImport.VendorID";
			DataTable dataBillImport = dtBase.ReadData(sqlSelect);
			dtgv_HoaDonNhap.DataSource = dataBillImport;
		}
		public void loadVendor()
        {
            List<Vendor> listVendor = VendorDAO.Instance.LoadVendorList();
            foreach (Vendor vendor in listVendor)
            {
                Guna2GradientButton btn = new Guna2GradientButton();
                
                btn.Text = vendor.VendorName1 + Environment.NewLine;
                btn.Click += btn_VendorClick;
                btn.Tag = vendor;
                switch (vendor.Status1)
                {
                    case 1:
						btn.BorderRadius = 25;
						btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
						btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
						btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
						btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
						btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
						btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
						btn.FillColor2 = System.Drawing.Color.Teal;
						btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						btn.ForeColor = System.Drawing.Color.White;
						btn.Size = new System.Drawing.Size(180, 133);
                        break;
                    case 0:
						btn.BorderRadius = 25;
						btn.FillColor = System.Drawing.Color.DeepPink;  
						btn.FillColor2 = System.Drawing.Color.DeepPink; 
						btn.ForeColor = System.Drawing.Color.White;
						btn.Size = new System.Drawing.Size(180, 133);
						btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						break;
				}
                flpn_Vendor.Controls.Add(btn);
            }
        }
        public void loadTableVendor()
        {
            string sqlSelect = "select Vendor.VendorID, Vendor.VendorName," +
                "case Vendor.Status " +
                    "when 0 then N'Ngừng hợp tác' " +
                    "when 1 then N'Đang hợp tác' " +
                    "end as Status, " +
				"COALESCE(count(Book.BookID),0) as N'Số đầu sách', " +
				"COALESCE(SUM(ISNULL(BillImportDetail.ImportAmount, 0) * ISNULL(Book.ImportPrice, 0)), 0) AS N'Tổng tiền nhập' "+
				"from Vendor " +
                "left join BillImport on Vendor.VendorID=BillImport.VendorID " +
                "left join BillImportDetail on BillImport.BillImportID=BillImportDetail.BillImportID " +
                "left join Book on BillImportDetail.BookID = Book.BookID " +
				"group by Vendor.VendorID, Vendor.VendorName, Vendor.Status";
            DataTable dataVendor = dtBase.ReadData(sqlSelect);
            dtgv_NhaCungCap.DataSource = dataVendor;
        }

		public void showVendor(string vendorID)
		{
			string sqlSelect = "select Vendor.VendorID, Vendor.VendorName," +
				"case Vendor.Status " +
					"when 0 then N'Ngừng hợp tác' " +
					"when 1 then N'Đang hợp tác' " +
					"end as Status, " +
				"COALESCE(count(Book.BookID),0) as N'Số đầu sách', " +
				"COALESCE(SUM(ISNULL(BillImportDetail.ImportAmount, 0) * ISNULL(Book.ImportPrice, 0)), 0) AS N'Tổng tiền nhập' " +
				"from Vendor " +
				"left join BillImport on Vendor.VendorID=BillImport.VendorID " +
				"left join BillImportDetail on BillImport.BillImportID=BillImportDetail.BillImportID " +
				"left join Book on BillImportDetail.BookID = Book.BookID " +
				"where Vendor.VendorID = @VendorID " +
				"group by Vendor.VendorID, Vendor.VendorName, Vendor.Status";

			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{ "@VendorID", vendorID}
			};

			DataTable dataVendor = dtBase.SearchData(sqlSelect, parameters);
			dtgv_NhaCungCap.DataSource = dataVendor;
		}


		private void btn_VendorClick(object sender, EventArgs e)
        {
			var button = sender as Guna2GradientButton;
			if (button != null)
			{
				var vendor = button.Tag as Vendor;
				if (vendor != null)
				{
					showVendor(vendor.VendorID1);
				}
			}
		}

        private void btn_Them_Click(object sender, EventArgs e)
        {
			DataTable dataAcc = dtBase.ReadData("select * from Vendor where VendorID=N'" + txb_MaNhaCC.Text + "'");
			if (dataAcc.Rows.Count > 0)
			{
				MessageBox.Show("Nhà cung cấp đã tồn tại !");
				return;
			}
			string sqlInsert = "Insert into Vendor values(@VendorID, @VendorName, @Status)";
			Dictionary<string, object> parameters = new Dictionary<string, object>()
			{
				{"@VendorID",txb_MaNhaCC.Text},
				{"@VendorName",txb_TenNhaCC.Text},
				{"@Status",cb_TrangThai.SelectedValue}

			};
			if (dtBase.ChangeData(sqlInsert, parameters))
			{
				MessageBox.Show("Thêm nhà cung cấp mới thành công !");
				loadTableVendor();
				flpn_Vendor.Controls.Clear();
                loadVendor();
				return;
			}
			else
			{
				MessageBox.Show("Thêm nhà cung cấp thất bại !");
			}
		}

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
			if (dtgv_NhaCungCap.CurrentRow == null)
			{
				MessageBox.Show("Bạn muốn xóa nhà cung cấp nào ?");
				return;
			}
			DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này không ?",
								   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					string maNCCcanxoa = dtgv_NhaCungCap.CurrentRow.Cells[0].Value.ToString();
					string sqlDel = "Delete from Vendor where VendorID = @VendorID";
					Dictionary<string, object> prmt = new Dictionary<string, object>()
					{
						{"@VendorID", maNCCcanxoa}
					};
					if (dtBase.ChangeData(sqlDel, prmt))
					{
						MessageBox.Show("Xóa nhà cung cấp thành công !");
						loadTableVendor();
						flpn_Vendor.Controls.Clear();
						loadVendor();
						return;
					}
					else
					{
						MessageBox.Show("Xóa sách thất bại !");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Không thể xóa nhà cung cấp này vì : " + ex.Message);
				}

			}
		}
		private void dtgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txb_MaNhaCC.Text = dtgv_NhaCungCap.CurrentRow.Cells[0].Value.ToString();
				txb_TenNhaCC.Text = dtgv_NhaCungCap.CurrentRow.Cells[1].Value.ToString();
				cb_TrangThai.Text = dtgv_NhaCungCap.CurrentRow.Cells[2].Value.ToString();
			}
		}
		private void btn_Sua_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
								 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				string sqlUpdate = "Update Vendor set VendorName=@VendorName, " +
					"Status=@Status " +
					"where VendorID=@VendorID";
				Dictionary<string, object> prmt = new Dictionary<string, object>()
				{
					{"@VendorID", txb_MaNhaCC.Text},
					{"@VendorName", txb_TenNhaCC.Text},
					{"@Status", cb_TrangThai.SelectedValue.ToString()},
				};
				if (dtBase.ChangeData(sqlUpdate, prmt))
				{
					MessageBox.Show("Cập nhật thành công !");
					loadTableVendor();
					flpn_Vendor.Controls.Clear();
					loadVendor();
					return;
				}
				else
				{
					MessageBox.Show("Cập nhật thất bại !");
					return;
				}
			}
		}

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
			foreach (var m in this.pn_Nhap.Controls)
			{
				if (m is Guna2TextBox)
				{
					Guna2TextBox textBox = (Guna2TextBox)m;
					textBox.Text = "";
				}

				else if (m is Guna2ComboBox)
				{
					Guna2ComboBox cb = (Guna2ComboBox)m;
					cb.SelectedIndex = -1;
				}
			}
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			loadTableVendor();
		}

		private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(dtgv_HoaDonNhap.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn hóa đơn muốn xem thông tin! ");
				return;
			}
			string sqlBillImportDetail = "select BillImportDetail.BillImportID, BillImportDetail.BookID," +
				"Book.BookName, BillImportDetail.ImportPrice, BillImportDetail.ImportAmount, Sum(BillImportDetail.ImportPrice*ImportAmount) as N'Thành tiền' " +
				"from BillImportDetail " +
				"inner join BillImport on BillImport.BillImportID = BillImportDetail.BillImportID " +
				"inner join Book on Book.BookID = BillImportDetail.BookID " +
				"where BillImport.BillImportID = @BillImportID " +
				"group by BillImportDetail.BillImportID, BillImportDetail.BookID, Book.BookName, " +
						  "BillImportDetail.ImportPrice, BillImportDetail.ImportAmount";
			Dictionary<string, object> prmtBillImpDetail = new Dictionary<string, object>()
			{
				{"@BillImportID", dtgv_HoaDonNhap.CurrentRow.Cells[0].Value.ToString() }
			};
			DataTable dtBillImpDetail = dtBase.SearchData(sqlBillImportDetail, prmtBillImpDetail);
			dtgv_ChiTietHDN.DataSource = dtBillImpDetail;
		}


		private void btn_Tim_Click(object sender, EventArgs e)
		{
			string keyword = txb_TuKhoa.Text.Trim();
			string sqlQuery = @"
				SELECT BillImportID, BillImport.EmployeeID, Employee.FullName, 
					   DateImport, Vendor.VendorName, TotalBillImport 
				FROM BillImport 
				INNER JOIN Employee ON Employee.EmployeeID = BillImport.EmployeeID 
				INNER JOIN Vendor ON Vendor.VendorID = BillImport.VendorID 
				WHERE 1=1";

			Dictionary<string, object> parameters = new Dictionary<string, object>();

			if (chkStartDate.Checked)
			{
				DateTime startDate = dtpk_NgayBatDau.Value.Date;
				sqlQuery += " AND DateImport >= @StartDate";
				parameters.Add("@StartDate", startDate);
			}
			if (chkEndDate.Checked)
			{
				DateTime endDate = dtpk_NgayKetThuc.Value.Date;
				sqlQuery += " AND DateImport <= @EndDate";
				parameters.Add("@EndDate", endDate);
			}

			if (!string.IsNullOrEmpty(keyword))
			{
				sqlQuery += " AND (Vendor.VendorName LIKE @Keyword OR Employee.FullName LIKE @Keyword)";
				parameters.Add("@Keyword", "%" + keyword + "%");
			}
			DataTable searchResults = dtBase.SearchData(sqlQuery, parameters);

			if (searchResults.Rows.Count > 0)
			{
				dtgv_HoaDonNhap.DataSource = searchResults;
				MessageBox.Show("Found!");
			}
			else
			{
				MessageBox.Show("Not Found!");
			}
		}
		private void btn_Huy_Click(object sender, EventArgs e)
		{
			loadBillImport();
		}
	}
}
