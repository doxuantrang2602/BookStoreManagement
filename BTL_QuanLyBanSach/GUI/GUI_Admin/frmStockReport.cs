using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
	public partial class frmStockReport : Form
	{
		DataProcesserTrang dtBase = new DataProcesserTrang();
		public frmStockReport()
		{
			InitializeComponent();
			dtgv_SoSachTon.ReadOnly = true;
			foreach (DataGridViewColumn column in dtgv_SoSachTon.Columns)
			{
				column.ReadOnly = true;
			}
		}
		public void LoadData()
		{
			string sqlStock = "select months.month as Thang, isnull(sum(TotalBillImport),0) as TongNhap " +
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
				"left join BillImport on months.month = Month(BillImport.DateImport) " +
				"where year(DateImport) = year(getdate()) " +
				"group by months.month";
			DataTable dt = dtBase.ReadData(sqlStock);
			Series series = new Series("Tổng tiền nhập");
			series.ChartType = SeriesChartType.Column;
			if (dt.Rows.Count == 0)
			{
				for (int i = 1; i <= 12; i++)
				{
					DataPoint point = new DataPoint();
					series.Points.Add(point);
				}
			}
			else
			{
				for (int i = 1; i <= 12; i++)
				{
					for (int z = 0; z < dt.Rows.Count; z++)
					{
						if (int.Parse(dt.Rows[z]["Thang"].ToString()) != i)
						{
							continue;
						}
						else
						{
							DataPoint point = new DataPoint(i, dt.Rows[z]["TongNhap"].ToString());
							series.Points.Add(point);
						}
					}
				}
			}
			chartThongKeTonKho.Series.Clear();
			chartThongKeTonKho.Series.Add(series);
		}
		private void frmStockReport_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btn_BaoCaoTonKho_Click(object sender, EventArgs e)
		{
			int selectedYear = Convert.ToInt32(cb_Nam.SelectedValue);
			string sqlReportStock = "select Book.BookID, Book.BookName, " +
				"isnull(sum(BillDetail.SaleAmount),0) as N'Tổng số lượng bán'," +
				"isnull(sum(BillImportDetail.ImportAmount), 0) as N'Tổng số lượng nhập'," +
				"abs(isnull(sum(BillDetail.SaleAmount),0) - isnull(sum(BillImportDetail.ImportAmount),0)) as N'Số lượng tồn'," +
				"abs(isnull(sum(BillDetail.SaleAmount),0) - isnull(sum(BillImportDetail.ImportAmount),0)) * isnull(Book.ImportPrice, 0) as N'Trị giá tồn kho' " +
				"from Book " +
				"Left join (select BookID, sum(Amount) as SaleAmount " +
				"from BillDetail inner join Bill on BillDetail.BillID=Bill.BillID and year(Bill.DateBill)=@Year " +
				"group by BookID) " +
				"BillDetail on Book.BookID = BillDetail.BookID " +
				"Left join (select BookID, sum(ImportAmount) as ImportAmount " +
				"from BillImportDetail inner join BillImport on BillImportDetail.BillImportID = BillImport.BillImportID and year(BillImport.DateImport)=@Year " +
				"group by BookID) " +
				"BillImportDetail on Book.BookID = BillImportDetail.BookID " +
				"group by Book.BookID, Book.BookName, Book.ImportPrice";
			Dictionary<string, object> prmt = new Dictionary<string, object>()
			{
				{ "@Year", selectedYear }
			};
			DataTable dataStock = dtBase.SearchData(sqlReportStock, prmt);	
			dtgv_SoSachTon.DataSource = dataStock;
		}
		private void cb_Nam_Click(object sender, EventArgs e)
		{
			string sqlYear = "select distinct year(DateImport) as Years from BillImport";
			DataTable dt = dtBase.ReadData(sqlYear);
			cb_Nam.DataSource = dt;
			cb_Nam.DisplayMember = "Years";
			cb_Nam.ValueMember = "Years";
			cb_Nam.SelectedIndex = -1;
		}
		private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sqlYear = "select months.month as Thang, isnull(sum(TotalBillImport),0) as TongNhap " +
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
				"left join BillImport on months.month = Month(DateImport) " +
				"where year(DateImport) = @Year " +
				"group by months.month";
			Dictionary<string, object> prmt = new Dictionary<string, object>()
			{
				{"@Year", cb_Nam.Text}
			};
			DataTable dt = dtBase.SearchData(sqlYear, prmt);
			Series series = new Series("Tổng tiền nhập");
			series.ChartType = SeriesChartType.Column;
			if (dt.Rows.Count == 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					DataPoint point = new DataPoint();
					series.Points.Add(point);
				}
			}
			else
			{
				for (int i = 1; i <= 12; i++)
				{
					for (int z = 0; z < dt.Rows.Count; z++)
					{
						if (int.Parse(dt.Rows[z]["Thang"].ToString()) != i)
						{
							continue;
						}
						else
						{
							DataPoint point = new DataPoint(i, dt.Rows[z]["TongNhap"].ToString());
							series.Points.Add(point);
						}
					}
				}
			}
			chartThongKeTonKho.Series.Clear();
			chartThongKeTonKho.Series.Add(series);
		}

		private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			if (cb_Thang.SelectedIndex == 0)
			{
				LoadData();
			}
			else if (cb_Thang.SelectedIndex == 2)
			{
				cb_Ngay.Items.Clear();
				cb_Ngay.Items.Add("");
				cb_Ngay.Items.Add("1 - 10");
				cb_Ngay.Items.Add("11 - 20");
				cb_Ngay.Items.Add("21-28");
			}
			else if (cb_Thang.SelectedIndex == 4 || cb_Thang.SelectedIndex == 6 || cb_Thang.SelectedIndex == 9 || cb_Thang.SelectedIndex == 11)
			{
				cb_Ngay.Items.Clear();
				cb_Ngay.Items.Add("");
				cb_Ngay.Items.Add("1 - 10");
				cb_Ngay.Items.Add("11 - 20");
				cb_Ngay.Items.Add("21 - 30");
			}
			else
			{
				cb_Ngay.Items.Clear();
				cb_Ngay.Items.Add("");
				cb_Ngay.Items.Add("1 - 10");
				cb_Ngay.Items.Add("11 - 20");
				cb_Ngay.Items.Add("21 - 31");
			}
		}
		public string[] mon(string input)
		{
			string[] arr = new string[2];
			if (input == "")
			{
				return arr;
			}
			arr = input.Split('-');
			return arr;
		}

		private void cb_Ngay_SelectedIndexChanged(object sender, EventArgs e)
		{
			Series series = new Series("Tổng tiền nhập");
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
							dt = dtBase.ReadData("Select Day(DateImport) as Ngay, Sum(TotalBillImport) as Value " +
													"from BillImport " +
													"where Day(DateImport) between " + arr[0] + " and " + arr[1] + " and Month(DateImport) = " + i + " " +
													"group by Day(DateImport)");
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
			chartThongKeTonKho.Series.Clear();
			chartThongKeTonKho.Series.Add(series);
		}
	}
}
