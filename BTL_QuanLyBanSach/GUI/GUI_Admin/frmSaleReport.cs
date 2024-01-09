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
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Packaging;
using Guna.UI2.WinForms;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
	public partial class frmSaleReport : Form
	{
		DataProcesserTrang dtBase = new DataProcesserTrang();
		public frmSaleReport()
		{
			InitializeComponent();
			dtgv_SoSach.ReadOnly = true;
			foreach (DataGridViewColumn column in dtgv_SoSach.Columns)
			{
				column.ReadOnly = true;
			}
		}
		public void LoadData()
		{
			string sqlReport = "select months.month as Thang, isnull(sum(TotalBill),0) as Tong " +
				"from (select 1 as month union all " +
					  "select 2 union all " +
					  "select 3 union all " +
					  "select 4 union all " +
					  "select 5 union all " +
					  "select 6 union all " +
					  "select 7 union all " +
					  "select 8 union all " +
					  "select 9 union all " +
					  "select 10 union all " +
					  "select 11 union all " +
					  "select 12) as months " +
			    "left join Bill on months.month = Month(DateBill) " +
				"where status = 1 and year(DateBill) = year(getdate()) " +
				"group by months.month";
			DataTable dt = dtBase.ReadData(sqlReport);
			Series series = new Series("Doanh Thu");
			series.ChartType = SeriesChartType.Column;
			if (dt.Rows.Count == 0)
			{
				for(int i = 1; i <= 12; i++)
				{
					DataPoint point = new DataPoint();
					series.Points.Add(point);
				}
			}
			else
			{
				for(int i = 1; i <= 12; i++)
				{
					for(int z = 0; z < dt.Rows.Count; z++)
					{
						if (int.Parse(dt.Rows[z]["Thang"].ToString()) != i)
						{
							continue;
						}
						else
						{
							DataPoint point = new DataPoint(i, dt.Rows[z]["Tong"].ToString());
							series.Points.Add(point);
						}
					}
				}
			}
			chartThongKe.Series.Clear();
			chartThongKe.Series.Add(series);
		}
		private void frmSaleReport_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void cb_Nam_Click(object sender, EventArgs e)
		{
			string sqlYear = "select distinct year(DateBill) as Years from Bill";
			DataTable dt = dtBase.ReadData(sqlYear);
			cb_Nam.DataSource = dt;
			cb_Nam.DisplayMember = "Years";
			cb_Nam.ValueMember = "Years";
			cb_Nam.SelectedIndex = -1;
		}
		private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sqlYear = "select months.month as Thang, isnull(sum(TotalBill),0) as Tong " +
				"from (select 1 as month union all " +
					  "select 2 union all " +
					  "select 3 union all " +
					  "select 4 union all " +
					  "select 5 union all " +
					  "select 6 union all " +
					  "select 7 union all " +
					  "select 8 union all " +
					  "select 9 union all " +
					  "select 10 union all " +
					  "select 11 union all " +
					  "select 12) as months " +
				"left join Bill on months.month = Month(DateBill) " +
				"where status = 1 and year(DateBill) = @Year " +
				"group by months.month";
			Dictionary<string, object> prmt = new Dictionary<string, object>()
			{
				{"@Year", cb_Nam.Text}
			};
			DataTable dt = dtBase.SearchData(sqlYear,prmt);
			Series series = new Series("Doanh Thu");
			series.ChartType = SeriesChartType.Column;
			if(dt.Rows.Count == 0)
			{
				for(int i = 0; i < dt.Rows.Count; i++)
				{
					DataPoint point = new DataPoint();
					series.Points.Add(point);
				}
			}
			else
			{
				for(int i =	1; i <= 12; i++)
				{
					for(int z = 0; z < dt.Rows.Count; z++)
					{
						if (int.Parse(dt.Rows[z]["Thang"].ToString()) != i){
							continue;
						}
						else
						{
							DataPoint point = new DataPoint(i, dt.Rows[z]["Tong"].ToString());
							series.Points.Add(point);
						}
					}
				}
			}
			chartThongKe.Series.Clear();
			chartThongKe.Series.Add(series);
		}

		private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			if(cb_Thang.SelectedIndex == 0)
			{
				LoadData();
			}
			else if(cb_Thang.SelectedIndex == 2)
			{
				cb_Ngay.Items.Clear();
				cb_Ngay.Items.Add("");
				cb_Ngay.Items.Add("1 - 10");
				cb_Ngay.Items.Add("11 - 20");
				cb_Ngay.Items.Add("21-28");
			}
			else if(cb_Thang.SelectedIndex == 4 || cb_Thang.SelectedIndex == 6 || cb_Thang.SelectedIndex == 9 || cb_Thang.SelectedIndex == 11)
			{
				cb_Ngay.Items.Clear();
				cb_Ngay.Items.Add("");
				cb_Ngay.Items.Add("1 - 10");
				cb_Ngay.Items.Add("11 - 20");
				cb_Ngay.Items.Add("21-30");
			}
			else
			{
				cb_Ngay.Items.Clear();
				cb_Ngay.Items.Add("");
				cb_Ngay.Items.Add("1 - 10");
				cb_Ngay.Items.Add("11 - 20");
				cb_Ngay.Items.Add("21-31");
			}
		}

		public string[] mon(string input)
		{
			string[] arr = new string[2];
			if(input == "")
			{
				return arr;
			}
			arr = input.Split('-');
			return arr;
		}
		private void cb_Ngay_SelectedIndexChanged(object sender, EventArgs e)
		{
			Series series = new Series("Doanh Thu");
			series.ChartType = SeriesChartType.Column;
			DataTable dt = new DataTable();
			if (cb_Ngay.SelectedIndex == 0 && cb_Thang.SelectedIndex == 0)
			{
				LoadData();
			}
			for (int i = 0; i < cb_Thang.Items.Count; i++)
			{
				if (cb_Thang.SelectedIndex == i)
				{
					for (int z = 1; z < cb_Ngay.Items.Count; z++)
					{
						if (cb_Ngay.SelectedIndex == z)
						{
							string[] arr = mon(cb_Ngay.SelectedItem.ToString());
							dt = dtBase.ReadData("Select Day(DateBill) as Ngay, Sum(TotalBill) as Value " +
													"from Bill " +
													"where Day(DateBill) between " + arr[0] + " and " + arr[1] + " and Month(DateBill) = " + i + " " +
													"group by Day(DateBill)");
							if (dt.Rows.Count == 0)
							{
								for (int t = int.Parse(arr[0]); t <= int.Parse(arr[1]); t++)
								{
									DataPoint point = new DataPoint(t, 0);
									series.Points.Add(point);
								}
							}
							else
							{
								for (int cnt = 0; cnt < dt.Rows.Count; cnt++)
								{
									DataPoint point = new DataPoint(int.Parse(dt.Rows[cnt]["Ngay"].ToString()), dt.Rows[cnt]["Value"].ToString());
									series.Points.Add(point);
								}
							}
						}
					}
				}
			}
			string[] arrs = mon(cb_Ngay.SelectedItem.ToString());
			chartThongKe.Series.Clear();
			chartThongKe.Series.Add(series);

			string sqlBook = "select Book.BookID, Book.BookName, sum(BillDetail.Amount) as N'Tổng số lượng bán' " +
					"from BillDetail " +
					"inner join Book on BillDetail.BookID = Book.BookID " +
					"inner join Bill on Bill.BillID = BillDetail.BillID " +
					"where Day(DateBill) between " + arrs[0] + " and " + arrs[1] + " " +
					"and Month(DateBill) = " + cb_Thang.Text + " " +
					"group by Book.BookID, Book.BookName";
			DataTable dtBooks = dtBase.ReadData(sqlBook);
			dtgv_SoSach.DataSource = dtBooks;

			string sqlDoanhThuNgay = "SELECT SUM(TotalBill) AS DoanhThu " +
							 "FROM Bill " +
							 "WHERE Day(DateBill) BETWEEN " + arrs[0] + " AND " + arrs[1] +
							 " AND Month(DateBill) = " + cb_Thang.Text +
							 " AND YEAR(DateBill) = " + cb_Nam.Text;
			DataTable dtDoanhThuNgay = dtBase.ReadData(sqlDoanhThuNgay);
			lbl_DoanhThu.Text = dtDoanhThuNgay.Rows.Count > 0 ? dtDoanhThuNgay.Rows[0]["DoanhThu"].ToString() : "0";

		}
		
		private void btn_BaoCao_Click(object sender, EventArgs e)
		{
			int selectedYear = Convert.ToInt32(cb_Nam.SelectedValue);
			string sqlReportBook = "select Book.BookID, Book.BookName, isnull(sum(BillDetail.Amount),0) as N'Tổng số lượng bán' " +
				"from Book " +
				"inner join BillDetail on Book.BookID=BillDetail.BookID " +
				"inner join Bill on Bill.BillID=BillDetail.BillID " +
				"where Year(DateBill) = @Year " +
				"group by Book.BookID, Book.BookName";
			Dictionary<string, object> prmt = new Dictionary<string, object>()
			{
				{"@Year",selectedYear }
			};
			DataTable dataReportBook = dtBase.SearchData(sqlReportBook, prmt);
			dtgv_SoSach.DataSource = dataReportBook;

			string sqlDoanhThu = "select sum(TotalBill) as DoanhThu " +
								 "from Bill where year(DateBill) = @Year AND Status = 1";
			DataTable dtDoanhThu = dtBase.SearchData(sqlDoanhThu, 
				new Dictionary<string, object> { 
					{ "@Year", selectedYear } 
				});
			lbl_DoanhThu.Text = dtDoanhThu.Rows.Count > 0 ? dtDoanhThu.Rows[0]["DoanhThu"].ToString() : "0";

		}
	}
}
