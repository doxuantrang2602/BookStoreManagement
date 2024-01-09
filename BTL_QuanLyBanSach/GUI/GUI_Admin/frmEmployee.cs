using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyBanSach.Classes;
using BTL_QuanLyBanSach.GUI.GUI_Login;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;
using Guna.UI2.WinForms;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    public partial class frmEmployee : Form
    {
        DataProcesserTrang dtBase = new DataProcesserTrang();
        public static frmEmployeeDetails frmEmplDt = new frmEmployeeDetails();
        public static frmLogin fLogin = new frmLogin();
        public frmEmployee()
        {
            InitializeComponent();
            loadTable();
            this.lbl_Admin.Text ="Admin: "+ fLogin.txb_Username.Text;			
		}
		private void frmEmployee_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dtgv_NhanVien.Columns)
            {
                column.ReadOnly = true;
            }
            string sqlRole = "select RoleID, RoleName from Role";
            DataTable dataRole = new DataTable();
            dataRole = dtBase.ReadData(sqlRole);
            cb_ChucVu1.DataSource = dataRole;
            cb_ChucVu1.DisplayMember = "RoleName";
            cb_ChucVu1.ValueMember = "RoleID";
            cb_ChucVu1.SelectedIndex = -1;

            string sqlSoLuong = "select count(Employee.EmployeeID) from Employee";
            int employeeCount = dtBase.GetScalarValue<int>(sqlSoLuong);
            lbl_TongNV.Text = $"Tổng số nhân sự: {employeeCount}";
            lbl_Ngay.Text = $"Ngày: { DateTime.Now.ToString()}";
		}
        public void loadTable()
        {
            string sqlSelect = "select EmployeeID, FullName, DateOfBirth,Address," +
                "Email, PhoneNumber, StartWorkDate, RoleName, Picture " +
                "from Employee " +
                "inner join Role on Role.RoleID=Employee.RoleID";
            DataTable dataEmpl = new DataTable();
            dataEmpl = dtBase.ReadData(sqlSelect);
            dtgv_NhanVien.DataSource = dataEmpl;
        }
        private void ctmn_Them_Click(object sender, EventArgs e)
        {
            frmEmplDt.Reset();
            frmEmplDt.OnDataChanged += loadTable;
            frmEmplDt.currentStatus = Status.Add;
            frmEmplDt.ShowDialog(this);
        }
        private void ctmn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_NhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn cập nhật !");
                return;
            }
            frmEmplDt.SetReadOnly(false);
            frmEmplDt.OnDataChanged += loadTable;
            frmEmplDt.currentStatus = Status.Update;
            frmEmplDt.EmployeeDetails(dtgv_NhanVien.CurrentRow);
            frmEmplDt.ShowDialog(this);
        }

        private void ctmn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_NhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa!");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string employeeID = dtgv_NhanVien.CurrentRow.Cells[0].Value.ToString(); 
                    string sqlDelete = "delete from Employee where EmployeeID = @EmployeeID";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        {"@EmployeeID", employeeID}
                    };

                    if (dtBase.ChangeData(sqlDelete, parameters))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        loadTable();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra. Không thể xóa nhân viên!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }

       
        private void ctmn_Xem_Click(object sender, EventArgs e)
        {
            if (dtgv_NhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xem thông tin!");
                return;
            }
            frmEmplDt.currentStatus = Status.View;
            frmEmplDt.EmployeeDetails(dtgv_NhanVien.CurrentRow);
            frmEmplDt.SetReadOnly(true);
            frmEmplDt.ShowDialog(this);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string keyword = txb_TuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }
            string query = "select EmployeeID, FullName, DateOfBirth,Address," +
                        "Email, PhoneNumber, StartWorkDate, RoleName, Picture " +
                        "from Employee " +
                        "inner join Role on Role.RoleID=Employee.RoleID " +
                        "where EmployeeID like @key or FullName like @key or DateOfBirth like @key or " +
                        "Address like @key or Email like @key or PhoneNumber = @key or " +
                        "StartWorkDate like @key or RoleName like @key";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Key", "%"+keyword+"%" }
            };
            System.Data.DataTable data = dtBase.SearchData(query, parameters);
            if (data.Rows.Count > 0)
            {
                dtgv_NhanVien.DataSource = data;
                MessageBox.Show("Found " + keyword + " !");
            }
            else
            {
                MessageBox.Show("Not Found " + keyword + " !");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            loadTable();
            cb_ChucVu1.SelectedIndex = -1;
        }

        private void dtgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_ChucVu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ChucVu1.SelectedIndex != -1)
            {
                try
                {
                    string selectedRoleName = cb_ChucVu1.GetItemText(cb_ChucVu1.SelectedItem);
                    string sqlFilter = "select EmployeeID, FullName, DateOfBirth,Address," +
                        "Email, PhoneNumber, StartWorkDate, RoleName, Picture " +
                        "from Employee " +
                        "inner join Role on Role.RoleID=Employee.RoleID " +
                        "where Role.RoleName=@RoleName";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        {"@RoleName", selectedRoleName}
                    };
                    DataTable filteredData = dtBase.SearchData(sqlFilter, parameters);
                    dtgv_NhanVien.DataSource = filteredData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lọc: " + ex.Message);
                }
            }
            else
            {
                loadTable(); 
            }
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
                    ws.Cells["B1:I1"].Merge = true;
                    ws.Cells["B1"].Value = "Bookstore Management NTN";
                    ws.Cells["B1"].Style.Font.Size = 18;
                    ws.Cells["B1"].Style.Font.Bold = true;
                    ws.Cells["B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["B2:I2"].Merge = true;
                    ws.Cells["B2"].Value = "Address: 206,Khu B3 , 469 Thanh Liệt - Thanh Trì - Hà Nội";
                    ws.Cells["B2"].Style.Font.Size = 12;
                    ws.Cells["B2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["B3:I3"].Merge = true;
                    ws.Cells["B3"].Value = "Phone: 0934683998";
                    ws.Cells["B3"].Style.Font.Size = 12;
                    ws.Cells["B3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["B4:I4"].Merge = true;
                    ws.Cells["B4"].Value = "Email: xuantrang260203@gmail.com";
                    ws.Cells["B4"].Style.Font.Size = 12;
                    ws.Cells["B4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["B5:I5"].Merge = true;
                    ws.Cells["B5"].Value = "Danh sách Nhân viên";
                    ws.Cells["B5"].Style.Font.Size = 18;
                    ws.Cells["B5"].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                    ws.Cells["B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["B6"].Value = "Mã nhân viên";
                    ws.Cells["C6"].Value = "Họ tên";
                    ws.Cells["D6"].Value = "Ngày sinh";
                    ws.Cells["E6"].Value = "Địa chỉ";
                    ws.Cells["F6"].Value = "Email";
                    ws.Cells["G6"].Value = "Số điện thoại";
                    ws.Cells["H6"].Value = "Ngày vào làm";
                    ws.Cells["I6"].Value = "Chức vụ";

                    using (ExcelRange rng = ws.Cells["B6:I6"])
                    {
                        rng.Style.Font.Bold = true;
                        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
                        rng.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        rng.AutoFilter = true;
                    }
                    DataTable dataTable = new DataTable();
                    foreach (DataGridViewColumn column in dtgv_NhanVien.Columns)
                    {
                        if (column != dtgv_NhanVien.Columns[dtgv_NhanVien.Columns.Count - 1])
                        {
                            dataTable.Columns.Add(column.HeaderText);
                        }
                    }
                    foreach (DataGridViewRow row in dtgv_NhanVien.Rows)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < row.Cells.Count - 1; i++) 
                        {
                            dataRow[i] = row.Cells[i].Value ?? DBNull.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                    ws.Cells["B7"].LoadFromDataTable(dataTable, false);
                    var dataRange = ws.Cells[7, 2, 6 + dataTable.Rows.Count, dataTable.Columns.Count + 1];
                    dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    for (int col = 2; col <= dataTable.Columns.Count + 1; col++)
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

        private void btn_InDS_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save a PDF File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A3);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font font = new Font(bf, 12);
                    Paragraph title = new Paragraph("Bookstore Management NTN", font);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);
                    pdfDoc.Add(new Paragraph("Address: 206,Khu B3 , 469 Thanh Liệt - Thanh Trì - Hà Nội", font));
                    pdfDoc.Add(new Paragraph("Phone: 0934683998", font));
                    pdfDoc.Add(new Paragraph("Email: xuantrang260203@gmail.com", font));
                    pdfDoc.Add(new Paragraph(" "));

                    PdfPTable table = new PdfPTable(dtgv_NhanVien.Columns.Count - 1);
                    table.WidthPercentage = 100;

                    float[] widths = new float[dtgv_NhanVien.Columns.Count - 1]; 
                    for (int i = 0; i < dtgv_NhanVien.Columns.Count - 1; i++) 
                    {
                        widths[i] = 4f;
                    }
                    table.SetWidths(widths);

                    foreach (DataGridViewColumn column in dtgv_NhanVien.Columns)
                    {
                        if (column != dtgv_NhanVien.Columns[dtgv_NhanVien.Columns.Count - 1]) 
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                            cell.BackgroundColor = new BaseColor(79, 129, 189);
                            table.AddCell(cell);
                        }
                    }
                    foreach (DataGridViewRow row in dtgv_NhanVien.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count - 1; i++)
                        {
                            table.AddCell(new Phrase(row.Cells[i].Value?.ToString() ?? string.Empty, font));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }

                MessageBox.Show("Xuất pdf thành công!", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
