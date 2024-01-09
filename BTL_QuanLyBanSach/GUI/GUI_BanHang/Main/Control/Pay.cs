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
	public partial class Pay : Form
	{
		DataProcesserNghien dataPro = new DataProcesserNghien();

		public Pay()
		{
			InitializeComponent();
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
			printBill.Range["A9"].Value = "Số ĐT Khách: " + txtPhoneNumber.Text;
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
		}

		private void Pay_Load(object sender, EventArgs e)
		{
			txtBillID.Text = U_ThuNgan.BillID;
			txtTotalBill.Text = U_ThuNgan.TotalBill;
			txtPhoneNumber.Text = U_ThuNgan.PhoneNumber;
			txtEmployeeID.Text = U_ThuNgan.EmployeeID;
			txtFullName.Text = U_ThuNgan.FullName;
			DataTable dt = new DataTable();
			dt = dataPro.DataRead("Select BookID as 'Mã sách',Price as 'Giá bán',Amount as 'Số lượng',Discount as 'Giảm giá',TotalCost as 'Thành tiền' from BillDetail where BillID = '"+txtBillID.Text+"'");
			dataViewDetail.DataSource = dt;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Bạn chắc chắn muốn hủy ?",
				"Hủy",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
				) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void txtMoneyCustomer_TextChanged(object sender, EventArgs e)
		{
			double TotalBill,MoneyCustomer,MoneyPay;
			TotalBill = double.Parse(txtTotalBill.Text);
			MoneyCustomer = double.Parse(txtMoneyCustomer.Text);
			MoneyPay = MoneyCustomer - TotalBill;
			txtMoneyPay.Text = MoneyPay.ToString();
		}
	}
}
