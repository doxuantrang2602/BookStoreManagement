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

namespace BTL_QuanLyBanSach
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//private void cb_Ngay_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	Series series = new Series("Series1");
		//	series.ChartType = SeriesChartType.Column;
		//	DataTable dt = new DataTable();
		//	if (cb_Ngay.SelectedIndex == 0 && cb_Thang.SelectedIndex == 0)
		//	{
		//		LoadData();
		//	}
		//	for (int i = 0; i < cb_Thang.Items.Count; i++)
		//	{
		//		if (cb_Thang.SelectedIndex == i)
		//		{
		//			for (int z = 1; z < cb_Ngay.Items.Count; z++)
		//			{
		//				if (cb_Ngay.SelectedIndex == z)
		//				{
		//					string[] arr = mon(cb_Ngay.SelectedItem.ToString());
		//					dt = dtBase.ReadData("Select Day(DateBill) as Ngay, Sum(TotalBill) as Value " +
		//											"from Bill " +
		//											"where Day(DateBill) between " + arr[0] + " and " + arr[1] + " and Month(DateBill) = " + i + " " +
		//											"group by Day(DateBill)");
		//					if (dt.Rows.Count == 0)
		//					{
		//						for (int t = int.Parse(arr[0]); t <= int.Parse(arr[1]); t++)
		//						{
		//							DataPoint point = new DataPoint(t, 0);
		//							series.Points.Add(point);
		//						}
		//					}
		//					else
		//					{
		//						for (int cnt = 0; cnt < dt.Rows.Count; cnt++)
		//						{
		//							DataPoint point = new DataPoint(int.Parse(dt.Rows[cnt]["Ngay"].ToString()), dt.Rows[cnt]["Value"].ToString());
		//							series.Points.Add(point);
		//						}
		//					}
		//				}
		//			}
		//		}
		//	}
		//	string[] arrs = mon(cb_Ngay.SelectedItem.ToString());
		//	chartThongKe.Series.Clear();
		//	chartThongKe.Series.Add(series);

		//	DataTable dtBooks = dtBase.ReadData("SELECT COUNT(DISTINCT BillDetail.BookID) AS SoSach " +
		//										"FROM BillDetail " +
		//										"INNER JOIN Bill ON Bill.BillID = BillDetail.BillID " +
		//										"WHERE Day(DateBill) BETWEEN " + arrs[0] + " AND " + arrs[1] + " " +
		//										"AND Month(DateBill) = " + cb_Thang.Text);
		//	DataTable dtBills = dtBase.ReadData("SELECT COUNT(BillID) AS SoHoaDon, SUM(TotalBill) AS DoanhThu " +
		//										"FROM Bill " +
		//										"WHERE Day(DateBill) BETWEEN " + arrs[0] + " AND " + arrs[1] + " " +
		//										"AND Month(DateBill) = " + cb_Thang.Text);
		//	lbl_SoSach.Text = dtBooks.Rows[0]["SoSach"].ToString();
		//	lbl_SoHoaDon.Text = dtBills.Rows[0]["SoHoaDon"].ToString();
		//	lbl_DoanhThu.Text = dtBills.Rows[0]["DoanhThu"].ToString();
		//}
	}
}
