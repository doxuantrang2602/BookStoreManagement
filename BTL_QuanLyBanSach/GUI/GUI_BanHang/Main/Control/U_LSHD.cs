using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL.Main.Control
{
    public partial class U_LSHD : UserControl
    {
        DataProcess.DataProcesserNghien dataPro = new DataProcess.DataProcesserNghien();
        public U_LSHD()
        {
            InitializeComponent();
        }

        private void U_LSHD_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataPro.DataRead("Select * from Bill");
            for (int i = 0;i<dt.Rows.Count; i++)
            {
                Guna2Button button = new Guna2Button();
                button.BorderRadius = 15;
                button.Width = 250;
                button.Text = dt.Rows[i][0].ToString();
                button.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                if (dt.Rows[i]["Status"].ToString() == "0")
                {
                    button.BackColor = Color.Red;
                }
                button.Name = "btn"+dt.Rows[i][0].ToString();
                button.Click += new System.EventHandler(this.btn_BillID_click);
                flowBillID.Controls.Add(button);
            }
        }

        private void btn_BillID_click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            DataTable data = new DataTable();
            data = dataPro.DataRead("Select Bill.EmployeeID, Bill.DateBill, Bill.TotalBill, Customer.FullName " +
                                    "from Bill inner join Customer on Bill.CustomerID = Customer.CustomerID " +
                                    "where Bill.BillID = '"+button.Text+"'");
            txtTotalBill.Text = data.Rows[0][2].ToString();
            txtEmployeeID.Text = data.Rows[0][0].ToString();
            DateBill.Text = data.Rows[0][1].ToString();
            txtFullName.Text = data.Rows[0][3].ToString();
            txtBillID.Text = button.Text;
            data = dataPro.DataRead("Select BookID as 'Mã sách',Price as 'Giá bán',Amount as 'Số lượng',Discount as 'Giảm giá',TotalCost as 'Thành tiền' from BillDetail where BillID = '" + button.Text+"'");
            dataViewDetailBill.DataSource = data;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            if(DataPro.Checked.Check(txtSearchBillID.Text))
            {
                MessageBox.Show(
                    "Bạn chưa nhập mã hóa đơn !!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            data = dataPro.DataRead("Select Bill.EmployeeID, Bill.DateBill, Bill.TotalBill, Customer.FullName " +
                                    "from Bill inner join Customer on Bill.CustomerID = Customer.CustomerID " +
                                    "where Bill.BillID = '" + txtSearchBillID.Text + "'");
            if(data.Rows.Count == 0 )
            {
                MessageBox.Show(
                    "Không có mã hóa đơn này !!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            txtTotalBill.Text = data.Rows[0][2].ToString();
            txtEmployeeID.Text = data.Rows[0][0].ToString();
            DateBill.Text = data.Rows[0][1].ToString();
            txtFullName.Text = data.Rows[0][3].ToString();
            data = dataPro.DataRead("Select BookID as 'Mã sách',Price as 'Giá bán',Amount as 'Số lượng',Discount as 'Giảm giá',TotalCost as 'Thành tiền' from BillDetail where BillID = '" + txtSearchBillID.Text + "'");
            dataViewDetailBill.DataSource = data;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            if (MessageBox.Show(
                "Bạn chắc chắn muốn hủy hóa đơn này ?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataPro.ChangeData("Update Bill set Status = '0' where BillID = '"+txtBillID.Text+"'");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range printBill = (Excel.Range)exSheet.Cells[1, 1];
            printBill.Range["A1:D1"].MergeCells = true;
            printBill.Range["A1"].Value = "CỬA HÀNG GIA NGHIÊN";
            printBill.Range["A2"].Value = "Địa chỉ: huyện Yên Mô - Tỉnh  Ninh Bình";
            printBill.Range["A3"].Value = "Điện thoại: 0368888315";
            printBill.Range["c5:f5"].MergeCells = true;
            printBill.Range["C5:F5"].Font.Size = 18;
            printBill.Range["C5:F5"].Font.Color = System.Drawing.Color.Red;
            printBill.Range["C5"].Value = "HÓA ĐƠN BÁN";
            printBill.Range["A7"].Value = "Mã HĐ: " + txtBillID.Text;
            printBill.Range["A8"].Value = "Khách hàng: " + txtFullName.Text;
            printBill.Range["A10"].Value = "STT ";
            printBill.Range["B10"].Value = "Mã Hàng ";
            printBill.Range["C10"].Value = "Tên hàng ";
            printBill.Range["D10"].Value = "Số lượng ";
            printBill.Range["E10"].Value = "Thành tiền ";
            int hang = 10;

            DataTable tblChiTiet = dataPro.DataRead("Select BillDetail.BookID,Book.BookName,BillDetail.Amount,BillDetail.TotalCost from BillDetail inner join Book on BillDetail.BookID=Book.BookID where BillDetail.BillID='" + txtBillID.Text + "'");
            for (int i = 0; i < tblChiTiet.Rows.Count; i++)
            {
                hang++;
                printBill.Range["A" + hang.ToString()].Value = (i + 1).ToString();
                printBill.Range["B" + hang.ToString()].Value = tblChiTiet.Rows[i]["BookID"];
                printBill.Range["C" + hang.ToString()].Value = tblChiTiet.Rows[i]["BookName"];
                printBill.Range["D" + hang.ToString()].Value = tblChiTiet.Rows[i]["Amount"];
                printBill.Range["E" + hang.ToString()].Value = tblChiTiet.Rows[i]["TotalCost"];
            }
            printBill.Range["D" + (hang + 1).ToString()].Value = "Tổng tiền: " + txtTotalBill.Text;
            printBill.Range["C" + (hang + 2).ToString()].Value = "Nhân viên bán: " + txtEmployeeID.Text;
            exSheet.Name = "HoaDonBan";
            exBook.Activate();
            if (file.ShowDialog() == DialogResult.OK)
                exBook.SaveAs(file.FileName.ToString());
            exApp.Quit();
            MessageBox.Show("In hóa đơn thành công");
        }
        
    }
}
