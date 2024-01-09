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
using Guna.UI2.WinForms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Excel = Microsoft.Office.Interop.Excel;
using Font = iTextSharp.text.Font;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    public partial class FrmBooks : Form
    {
        DataProcesserTrang dtBase = new DataProcesserTrang();
        public FrmBooks()
        {
            InitializeComponent();
            loadTableBook();
            loadTableCat();
            loadTablePub();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewColumn column in dtgv_Sach.Columns)
            {
                column.ReadOnly = true;
            }
            foreach (DataGridViewColumn column in dtgv_TheLoai.Columns)
            {
                column.ReadOnly = true;
            }
            foreach (DataGridViewColumn column in dtgv_NhaXuatBan.Columns)
            {
                column.ReadOnly = true;
            }
            string sqlCategory = "select CategoryID, CategoryName from Category";
            DataTable dataCat = dtBase.ReadData(sqlCategory);
            cb_TheLoai.DataSource = dataCat;
            cb_TheLoai.DisplayMember = "CategoryName";
            cb_TheLoai.ValueMember = "CategoryID";
            cb_TheLoai.SelectedIndex = -1;

            string sqlPublisher = "select PublisherID, PublisherName from Publisher";
            DataTable dataPub = dtBase.ReadData(sqlPublisher);
            cb_NhaXuatBan.DataSource = dataPub;
            cb_NhaXuatBan.DisplayMember = "PublisherName";
            cb_NhaXuatBan.ValueMember = "PublisherID";
            cb_NhaXuatBan.SelectedIndex = -1;

        }
        public void loadTableCat()
        {
            string sqlSelect = "select Category.CategoryID, CategoryName, count(Book.BookID) as N'Số lượng sách' " +
                "from Category " +
                "left join Book on Category.CategoryID=Book.CategoryID " +
                "group by Category.CategoryID, CategoryName";
            DataTable dataCat = dtBase.ReadData(sqlSelect);
            dtgv_TheLoai.DataSource = dataCat;
        }
        public void loadTablePub()
        {
            string sqlSelect = "select Publisher.PublisherID, PublisherName, count(Book.BookID) as N'Số lượng sách' " +
                "from Publisher " +
                "left join Book on Publisher.PublisherID=Book.PublisherID " +
                "group by Publisher.PublisherID, PublisherName";
            DataTable dataPub = dtBase.ReadData(sqlSelect);
            dtgv_NhaXuatBan.DataSource = dataPub;
        }

        public void loadTableBook()
        {
            string sqlSelect = "Select Book.BookID, Book.BookName, Book.Author, Category.CategoryName," +
                "PublisherName, Book.ImportPrice, Book.Price,Book.StoreAmount, Book.Description " +
                "from Book " +
                "inner join Category on Category.CategoryID=Book.CategoryID " +
                "inner join Publisher on Publisher.PublisherID = Book.PublisherID";
            DataTable dataBook = dtBase.ReadData(sqlSelect);
            dtgv_Sach.DataSource = dataBook;
        }

        private void dtgv_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txb_MaSach.Text = dtgv_Sach.CurrentRow.Cells[0].Value.ToString();
                txb_TenSach.Text = dtgv_Sach.CurrentRow.Cells[1].Value.ToString();
                txb_TacGia.Text = dtgv_Sach.CurrentRow.Cells[2].Value.ToString();
                cb_TheLoai.Text = dtgv_Sach.CurrentRow.Cells[3].Value.ToString();
                cb_NhaXuatBan.Text = dtgv_Sach.CurrentRow.Cells[4].Value.ToString();
                txb_DonGiaNhap.Text = dtgv_Sach.CurrentRow.Cells[5].Value.ToString();
                txb_DonGiaBan.Text = dtgv_Sach.CurrentRow.Cells[6].Value.ToString();              
                nmr_SoLuong.Value = Convert.ToInt32(dtgv_Sach.CurrentRow.Cells[7].Value);
                rtb_MoTa.Text = dtgv_Sach.CurrentRow.Cells[8].Value.ToString();             
            }
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            DataTable dtBookeID = dtBase.ReadData("Select * from Book where BookID=N'" + txb_MaSach.Text + "'");
            if (dtBookeID.Rows.Count > 0)
            {
                MessageBox.Show("Mã sách đã tồn tại. Vui lòng chọn mã khác!");
                return;
            }
            string sqlInsert = "Insert into Book values(@BookID, @BookName, @Author, @CategoryID, " +
                "@PublisherID,@ImportPrice,@Price,@StoreAmount,0,2023,@Description)";
            Dictionary<string, object> prmt = new Dictionary<string, object>()
            {
                {"@BookID", txb_MaSach.Text },
                {"@BookName", txb_TenSach.Text },
                {"@Author", txb_TacGia.Text },
                {"@CategoryID", cb_TheLoai.SelectedValue },
                {"@PublisherID", cb_NhaXuatBan.SelectedValue },
                {"@ImportPrice", txb_DonGiaNhap.Text },
                {"@Price", txb_DonGiaBan.Text },
                {"@StoreAmount", nmr_SoLuong.Value },
                {"@Description", rtb_MoTa.Text }
            };
            if (dtBase.ChangeData(sqlInsert, prmt))
            {
                MessageBox.Show("Thêm sách mới thành công !");
                loadTableBook();
                return;
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại !");
            }
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            if (dtgv_Sach.CurrentRow == null)
            {
                MessageBox.Show("Bạn muốn xóa sách nào ?");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa sách này không ?",
                                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    string maSachCanXoa = dtgv_Sach.CurrentRow.Cells[0].Value.ToString();
                    string sqlDel = "Delete from Book where BookID = @BookID";
                    Dictionary<string, object> prmt = new Dictionary<string, object>()
                    {
                        {"@BookID", maSachCanXoa}
                    };
                    if (dtBase.ChangeData(sqlDel, prmt))
                    {
                        MessageBox.Show("Xóa thành công !");
                        loadTableBook();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại !");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
               
            }
        }

        private void btn_EditBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string sqlUpdate = "Update Book set BookName=@BookName, Author=@Author, CategoryID=@CategoryID," +
                    "PublisherID=@PublisherID, ImportPrice=@ImportPrice, Price=@Price, StoreAmount=@StoreAmount," +
                    "Description=@Description " +
                    "where BookID=@BookID";
                Dictionary<string, object> prmt = new Dictionary<string, object>()
                {
                    {"@BookID", txb_MaSach.Text},
                    {"@BookName", txb_TenSach.Text},
                    {"@Author", txb_TacGia.Text},
                    {"@CategoryID", cb_TheLoai.SelectedValue},
                    {"@PublisherID", cb_NhaXuatBan.SelectedValue},
                    {"@ImportPrice", txb_DonGiaNhap.Text},
                    {"@Price",txb_DonGiaBan.Text},
                    {"@StoreAmount", nmr_SoLuong.Value},
                    {"@Description", rtb_MoTa.Text}
                };
                if (dtBase.ChangeData(sqlUpdate, prmt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    loadTableBook();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    return;
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            foreach (var m in this.pn_Nhap1.Controls)
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
            foreach (var n in this.pn_Nhap2.Controls)
            {
                if (n is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)n;
                    textBox.Text = "";
                }
                else if (n is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)n;
                    richTextBox.Text = "";
                }
                else if (n is Guna2NumericUpDown)
                {
                    Guna2NumericUpDown nmr = (Guna2NumericUpDown)n;
                    nmr.Value = 0;
                }
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txb_TuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }
            string query = "Select BookID, BookName, Author, CategoryName, PublisherName, ImportPrice, Price," +
                "StoreAmount, Description " +
                "from Book " +
                "inner join Category on Category.CategoryID=Book.CategoryID " +
                "inner join Publisher on Publisher.PublisherID=Book.PublisherID " +
                "where BookID like @Key or BookName like @Key or Author like @Key or " +
                "CategoryName like @Key or PublisherName like @Key or ImportPrice like @Key or " +
                "Price like @Key or StoreAmount like @Key";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Key", "%"+keyword+"%" }
            };
            System.Data.DataTable data = dtBase.SearchData(query, parameters);
            if (data.Rows.Count > 0)
            {
                dtgv_Sach.DataSource = data;
                MessageBox.Show("Found " + keyword + " !");
            }
            else
            {
                MessageBox.Show("Not Found " + keyword + " !");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            loadTableBook();
        }

        private void btn_PrintPdf_Click(object sender, EventArgs e)
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

                    PdfPTable table = new PdfPTable(dtgv_Sach.Columns.Count);
                    table.WidthPercentage = 100;

                    float[] widths = new float[dtgv_Sach.Columns.Count];
                    for (int i = 0; i < dtgv_Sach.Columns.Count; i++)
                    {
                        widths[i] = 4f;
                    }
                    table.SetWidths(widths);
                    foreach (DataGridViewColumn column in dtgv_Sach.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                        cell.BackgroundColor = new BaseColor(79, 129, 189);
                        table.AddCell(cell);
                    }
                    foreach (DataGridViewRow row in dtgv_Sach.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty, font));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }

                MessageBox.Show("Xuất pdf thành công!", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
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
                    ws.Cells["C1:I1"].Merge = true;
                    ws.Cells["C1"].Value = "Bookstore Management NTN";
                    ws.Cells["C1"].Style.Font.Size = 18;
                    ws.Cells["C1"].Style.Font.Bold = true;
                    ws.Cells["C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C2:I2"].Merge = true;
                    ws.Cells["C2"].Value = "Address: 206,Khu B3 , 469 Thanh Liệt - Thanh Trì - Hà Nội";
                    ws.Cells["C2"].Style.Font.Size = 12;
                    ws.Cells["C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C3:I3"].Merge = true;
                    ws.Cells["C3"].Value = "Phone: 0934683998";
                    ws.Cells["C3"].Style.Font.Size = 12;
                    ws.Cells["C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C4:I4"].Merge = true;
                    ws.Cells["C4"].Value = "Email: xuantrang260203@gmail.com";
                    ws.Cells["C4"].Style.Font.Size = 12;
                    ws.Cells["C4"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["C5:I5"].Merge = true;
                    ws.Cells["C5"].Value = "Danh sách Sách";
                    ws.Cells["C5"].Style.Font.Size = 18;
                    ws.Cells["C5"].Style.Font.Color.SetColor(System.Drawing.Color.Red);
                    ws.Cells["C5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["B6"].Value = "Mã sách";
                    ws.Cells["C6"].Value = "Tên sách";
                    ws.Cells["D6"].Value = "Tác giả";
                    ws.Cells["E6"].Value = "Thể loại";
                    ws.Cells["F6"].Value = "Nhà xuất bản";
                    ws.Cells["G6"].Value = "Đơn giá nhập";
                    ws.Cells["H6"].Value = "Đơn giá bán";
                    ws.Cells["I6"].Value = "Số lượng";
                    ws.Cells["J6"].Value = "Mô tả";

                    using (ExcelRange rng = ws.Cells["B6:J6"])
                    {
                        rng.Style.Font.Bold = true;
                        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
                        rng.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        rng.AutoFilter = true;
                    }
                    DataTable dataTable = new DataTable();
                    foreach (DataGridViewColumn column in dtgv_Sach.Columns)
                    {
                        dataTable.Columns.Add(column.HeaderText);
                    }
                    foreach (DataGridViewRow row in dtgv_Sach.Rows)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (i == dtgv_Sach.Columns.Count - 1)
                            {
                                dataRow[i] = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "";
                            }
                            else
                            {
                                dataRow[i] = row.Cells[i].Value ?? DBNull.Value;
                            }
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                    ws.Cells["B7"].LoadFromDataTable(dataTable, false);
                    var dataRange = ws.Cells[7, 2, 6 + dataTable.Rows.Count, dataTable.Columns.Count + 1];
                    dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    for (int col = 2; col <= dataTable.Columns.Count + 1; col++) 
                    {
                        ws.Column(col).AutoFit();
                        ws.Column(col).Width = ws.Column(col).Width +2;
                    }
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    pck.SaveAs(excelFile);

                    MessageBox.Show("Xuất Excel thành công !", "Export Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //private void btn_ExportExcel_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog file = new SaveFileDialog();
        //    Excel.Application exApp = new Excel.Application();
        //    Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
        //    Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Sheets[1];
        //    Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; 
        //}

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }


        private void btn_ThemTheLoai_Click(object sender, EventArgs e)
        {
            DataTable dtTL = dtBase.ReadData("Select * from Category where CategoryID=N'" + txb_MaTheLoai.Text + "'");
            if (dtTL.Rows.Count > 0)
            {
                MessageBox.Show("Mã thể loại đã tồn tại. Vui lòng chọn mã khác!");
                return;
            }
            string sqlInsert = "Insert into Category values(@CategoryID, @CategoryName)";
            Dictionary<string, object> prmt = new Dictionary<string, object>()
            {
                {"@CategoryID", txb_MaTheLoai.Text },
                {"@CategoryName", txb_TenTheLoai.Text },
            };
            if (dtBase.ChangeData(sqlInsert, prmt))
            {
                MessageBox.Show("Thêm thể loại mới thành công !");
                loadTableCat();
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }

        private void btn_SuaTheLoai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlUpdate = "Update Category set CategoryName=@CategoryName " +
                                   "where CategoryID=@CategoryID";
                Dictionary<string, object> prmt = new Dictionary<string, object>()
                {
                    {"@CategoryID", txb_MaTheLoai.Text},
                    {"@CategoryName", txb_TenTheLoai.Text}
                };
                if (dtBase.ChangeData(sqlUpdate, prmt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    loadTableCat();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    return;
                }
            }
        }

        private void btn_RefreshTheLoai_Click(object sender, EventArgs e)
        {
            foreach (var m in this.pn_NhapTheLoai.Controls)
            {
                if (m is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)m;
                    textBox.Text = "";
                }
            }
        }
        private void dtgv_TheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txb_MaTheLoai.Text = dtgv_TheLoai.CurrentRow.Cells[0].Value.ToString();
                txb_TenTheLoai.Text = dtgv_TheLoai.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btn_TimCat_Click(object sender, EventArgs e)
        {
            string keyword = txb_TuKhoaTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }
            string query = "Select Category.CategoryID, CategoryName, count(Book.CategoryID) as N'Số lượng sách' " +
                "from Category " +
                "left join Book on Category.CategoryID=Book.CategoryID " +
                "where Category.CategoryID like @Key or CategoryName like @Key " +
                "group by Category.CategoryID, CategoryName ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Key", "%"+keyword+"%" }
            };
            System.Data.DataTable data = dtBase.SearchData(query, parameters);
            if (data.Rows.Count > 0)
            {
                dtgv_TheLoai.DataSource = data;
                MessageBox.Show("Found " + keyword + " !");
            }
            else
            {
                MessageBox.Show("Not Found " + keyword + " !");
            }
        }

        private void btn_HuyCat_Click(object sender, EventArgs e)
        {
            loadTableCat();
        }

        private void btn_ThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            DataTable dtTL = dtBase.ReadData("Select * from Publisher where PublisherID=N'" + txb_MaNhaXB.Text + "'");
            if (dtTL.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhà xuất bản đã tồn tại. Vui lòng chọn mã khác!");
                return;
            }
            string sqlInsert = "Insert into Publisher values(@PublisherID, @PublisherName)";
            Dictionary<string, object> prmt = new Dictionary<string, object>()
            {
                {"@PublisherID", txb_MaNhaXB.Text },
                {"@PublisherName", txb_TenNhaXB.Text },
            };
            if (dtBase.ChangeData(sqlInsert, prmt))
            {
                MessageBox.Show("Thêm nhà xuất bản mới thành công !");
                loadTablePub();
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }

        private void btn_SuaNhaXuatBan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlUpdate = "Update Publisher set PublisherName=@PublisherName " +
                                   "where PublisherID=@PublisherID";
                Dictionary<string, object> prmt = new Dictionary<string, object>()
                {
                    {"@PublisherID", txb_MaNhaXB.Text },
                    {"@PublisherName", txb_TenNhaXB.Text },
                };
                if (dtBase.ChangeData(sqlUpdate, prmt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    loadTablePub();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    return;
                }
            }
        }

        private void btn_RefreshNhaXB_Click(object sender, EventArgs e)
        {
            foreach (var m in this.pn_NhapNhaXB.Controls)
            {
                if (m is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)m;
                    textBox.Text = "";
                }
            }
        }

        private void btn_TimNhaXB_Click(object sender, EventArgs e)
        {
            string keyword = txb_TuKhoaNXB.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }
            string query = "Select Publisher.PublisherID, Publisher.PublisherName,count(Book.BookID) as N'Số lượng sách' " +
                "from Publisher " +
                "left join Book on Publisher.PublisherID=Book.PublisherID " +
                "where Publisher.PublisherID like @Key or Publisher.PublisherName like @Key " +
                "group by Publisher.PublisherID, Publisher.PublisherName ";
                
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Key", "%"+keyword+"%" }
            };
            System.Data.DataTable data = dtBase.SearchData(query, parameters);
            if (data.Rows.Count > 0)
            {
                dtgv_NhaXuatBan.DataSource = data;
                MessageBox.Show("Found " + keyword + " !");
            }
            else
            {
                MessageBox.Show("Not Found " + keyword + " !");
            }
        }

        private void btn_HuyNhaXB_Click(object sender, EventArgs e)
        {
            loadTablePub();
        }

        private void dtgv_NhaXuatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txb_MaNhaXB.Text = dtgv_NhaXuatBan.CurrentRow.Cells[0].Value.ToString();
                txb_TenNhaXB.Text = dtgv_NhaXuatBan.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
