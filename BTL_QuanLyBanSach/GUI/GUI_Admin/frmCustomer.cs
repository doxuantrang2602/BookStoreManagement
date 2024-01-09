using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyBanSach.GUI.GUI_Login;
using Guna.UI2.WinForms;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    public partial class frmCustomer : Form
    {
        DataProcesserTrang dtBase = new DataProcesserTrang();
        public static frmLogin frmLogin = new frmLogin();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmCustomer()
        {
            InitializeComponent();
            loadTable();
            dtgv_KhachHang.ReadOnly = true;
            foreach (DataGridViewColumn column in dtgv_KhachHang.Columns)
            {
                column.ReadOnly = true;
            }
            this.lbl_Admin.Text = "Admin: " + frmLogin.txb_Username.Text;
            string sqlSoLuong = "Select count(CustomerID) from Customer";
            int customerCount = dtBase.GetScalarValue<int>(sqlSoLuong);
            lbl_TongNV.Text = $"Tổng số khách hàng: {customerCount}";
            lbl_Ngay.Text = $"Ngày: {DateTime.Now.ToString()}";

        }

        public void loadTable()
        {
            string sqlSelect = "Select Customer.CustomerID, Customer.FullName, Customer.Email," +
                "Customer.PhoneNumber from Customer";
            DataTable dataCustomer = new DataTable();
            dataCustomer = dtBase.ReadData(sqlSelect);
            dtgv_KhachHang.DataSource = dataCustomer;
            foreach (DataGridViewColumn col in dtgv_KhachHang.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void pn_ThongTin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pn_ThongTin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pn_ThongTin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataTable dataKH = dtBase.ReadData("select * from Customer where CustomerID= N'" + txb_MaKH.Text + "'");
            if (dataKH.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại !");
                return;
            }
            string sqlInsert = "Insert into Customer values(@CustomerID,@FullName,@Email,@PhoneNumber)";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@CustomerID",txb_MaKH.Text },
                {"@FullName",txb_TenKH.Text },
                {"@Email",txb_EmailKH.Text },
                {"@PhoneNumber",txb_SdtKH.Text }
            };
            if (dtBase.ChangeData(sqlInsert, parameters))
            {
                MessageBox.Show("Thêm khách hàng mới thành công");
                loadTable();
                return;
            }
            else
            {
                MessageBox.Show("Thêm khách hàng mới thất bại");
            }
        }
        private void dtgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txb_MaKH.Text = dtgv_KhachHang.CurrentRow.Cells[0].Value.ToString();
                txb_TenKH.Text = dtgv_KhachHang.CurrentRow.Cells[1].Value.ToString();
                txb_EmailKH.Text = dtgv_KhachHang.CurrentRow.Cells[2].Value.ToString();
                txb_SdtKH.Text = dtgv_KhachHang.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlUpdate = "Update Customer set FullName=@FullName, Email=@Email,PhoneNumber=@PhoneNumber " +
                    "where CustomerID=@CustomerID";
                Dictionary<string, object> prmt = new Dictionary<string, object>()
                {
                    {"@CustomerID", txb_MaKH.Text},
                    {"@FullName", txb_TenKH.Text},
                    {"@Email", txb_EmailKH.Text},
                    {"@PhoneNumber", txb_SdtKH.Text}
                };
                if (dtBase.ChangeData(sqlUpdate, prmt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    loadTable();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    return;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_KhachHang.CurrentRow == null)
            {
                MessageBox.Show("Bạn muốn xóa sách nào ?");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này không ?",
                                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string maKHCanXoa = dtgv_KhachHang.CurrentRow.Cells[0].Value.ToString();
                    string sqlDel = "Delete from Customer where CustomerID = @CustomerID";
                    Dictionary<string, object> prmt = new Dictionary<string, object>()
                    {
                        {"@CustomerID",maKHCanXoa}
                    };
                    if (dtBase.ChangeData(sqlDel, prmt))
                    {
                        MessageBox.Show("Xóa thành công !");
                        loadTable();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }

            }
        }

        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            foreach (Control m in this.gr_Nhap.Controls)
            {
                if (m is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)m;
                    textBox.Text = "";
                }
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string keyword = txb_TuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }
            string query = "select Customer.CustomerID, Customer.FullName, Customer.Email, Customer.PhoneNumber " +
                "from Customer where CustomerID like @Key or FullName like @Key or Email like @Key or " +
                "PhoneNumber like @Key";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@Key","%"+keyword+"%"}
            };
            DataTable dataCustomer = dtBase.SearchData(query, parameters);
            if (dataCustomer.Rows.Count > 0)
            {
                dtgv_KhachHang.DataSource = dataCustomer;
                MessageBox.Show("Found " + keyword + " !");
                return;
            }
            else
            {
                MessageBox.Show("Not Found " + keyword + " !");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            loadTable();
            txb_TuKhoa.Text = "";
        }

        private void btn_InDS_Click(object sender, EventArgs e)
        {

        }
        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Save an Excel File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage pck = new ExcelPackage())
                {

                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Books");
                    ws.Cells["C1:F1"].Merge = true;
                    ws.Cells["C1"].Value = "Bookstore Management NTN ";
                    ws.Cells["C1"].Style.Font.Size = 18;
                    ws.Cells["C1"].Style.Font.Bold = true;
                    ws.Cells["C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C2:F2"].Merge = true;
                    ws.Cells["C2"].Value = "Address: 206,Khu B3 , 469 Thanh Liệt - Thanh Trì - Hà Nội";
                    ws.Cells["C2"].Style.Font.Size = 12;
                    ws.Cells["C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C3:F3"].Merge = true;
                    ws.Cells["C3"].Value = "Phone: 0934683998";
                    ws.Cells["C3"].Style.Font.Size = 12;
                    ws.Cells["C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C4:F4"].Merge = true;
                    ws.Cells["C4"].Value = "Email: xuantrang260203@gmail.com";
                    ws.Cells["C4"].Style.Font.Size = 12;
                    ws.Cells["C4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C5:F5"].Merge = true;
                    ws.Cells["C5"].Value = "Danh sách Khách hàng";
                    ws.Cells["C5"].Style.Font.Size = 18;
                    ws.Cells["C5"].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                    ws.Cells["C5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C6"].Value = "Mã Khách hàng";
                    ws.Cells["D6"].Value = "Họ và tên";
                    ws.Cells["E6"].Value = "Email";
                    ws.Cells["F6"].Value = "Số điện thoại";

                    using (ExcelRange rng = ws.Cells["C6:F6"])
                    {
                        rng.Style.Font.Bold = true;
                        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
                        rng.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        rng.AutoFilter = true;
                    }
                    DataTable dataTable = new DataTable();
                    foreach (DataGridViewColumn column in dtgv_KhachHang.Columns)
                    {
                        dataTable.Columns.Add(column.HeaderText);
                    }
                    foreach (DataGridViewRow row in dtgv_KhachHang.Rows)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value ?? DBNull.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                    ws.Cells["C7"].LoadFromDataTable(dataTable, false);
                    var dataRange = ws.Cells[7, 3, 6 + dataTable.Rows.Count, 3 + dataTable.Columns.Count];
                    dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    for (int col = 3; col <= 6; col++)
                    {
                        ws.Column(col).AutoFit();
                        ws.Column(col).Width = ws.Column(col).Width + 2;
                    }
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    pck.SaveAs(excelFile);

                    MessageBox.Show("Xuất Excel thành công !", "Export Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    
    }
}
    