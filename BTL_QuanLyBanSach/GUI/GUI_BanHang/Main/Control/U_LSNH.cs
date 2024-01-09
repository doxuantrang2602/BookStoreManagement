using Guna.UI2.WinForms;
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
using System.Windows.Forms.VisualStyles;

namespace BTL.Main.Control
{
    public partial class U_LSNH : UserControl
    {
        DataProcess.DataProcesserNghien dataPro = new DataProcess.DataProcesserNghien();
        public U_LSNH()
        {
            InitializeComponent();
        }
		public void Load()
		{
			DataTable dt = new DataTable();
			dt = dataPro.DataRead("Select months.month as Thang, ISNULL(SUM(TotalBill),0) as Tong " +
				"from ( SELECT 1 AS month UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12) as months " +
				"left join Bill on months.month = MONTH(DateBill) " +
				"where Status = 1 and Year(DateBill) = YEAR(GETDATE()) group by months.month");
			Series series = new Series("Series1");
			series.ChartType = SeriesChartType.Column;
			if (dt.Rows.Count == 0)
			{
				for (int i = 1; i <= 12; i++)
				{
					DataPoint point = new DataPoint(i, 0);
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
							DataPoint point = new DataPoint(i, dt.Rows[z]["Tong"].ToString());
							series.Points.Add(point);
						}
					}
				}
			}
			Graphics.Series.Clear();
			Graphics.Series.Add(series);
		}
        private void U_LSNH_Load(object sender, EventArgs e)
        {
			Load();
        }

        private void cbYear_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataPro.DataRead("Select DISTINCT Year(DateBill) as Years from Bill");
			cbYear.DataSource = dt;
			cbYear.DisplayMember = "Years";
			cbYear.ValueMember = "Years";
        }

        private void cbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
			DataTable dt = new DataTable();
			if (cbMonth.SelectedIndex == 0)
			{
				Load();
			}
            else if(cbMonth.SelectedIndex == 2)
            {
                cbDay.Items.Clear();
                cbDay.Items.Add("");
                cbDay.Items.Add("1 - 10");
                cbDay.Items.Add("11 - 20");
                cbDay.Items.Add("21-28");
            }
            else if (cbMonth.SelectedIndex == 4 || cbMonth.SelectedIndex == 6 || cbMonth.SelectedIndex == 9 || cbMonth.SelectedIndex == 11)
            {
                cbDay.Items.Clear();
				cbDay.Items.Add("");
				cbDay.Items.Add("1 - 10");
                cbDay.Items.Add("11 - 20");
                cbDay.Items.Add("21-30");
            }
            else
            {
                cbDay.Items.Clear();
				cbDay.Items.Add("");
				cbDay.Items.Add("1 - 10");
                cbDay.Items.Add("11 - 20");
                cbDay.Items.Add("21-31");
            }
        }

		public string[] mon(string input)
		{
			string[] array = new string[2];
			if (input == "")
				return array;
			array = input.Split('-');
			return array;
		}

		private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
		{
			table.Controls.Clear();
			Series series = new Series("Series1");
			series.ChartType = SeriesChartType.Column;
			DataTable dt = new DataTable();
			if (cbDay.SelectedIndex == 0 && cbMonth.SelectedIndex == 0)
			{
				Load();
			}
			for (int i = 0; i < cbMonth.Items.Count; i++)
			{
				if (cbMonth.SelectedIndex == i)
				{
					for (int z = 1; z < cbDay.Items.Count; z++)
					{
						if (cbDay.SelectedIndex == z)
						{
							string[] arr =  mon(cbDay.SelectedItem.ToString());
							dt = dataPro.DataRead("Select Day(DateBill) as Ngay, Sum(TotalBill) as Value " +
													"from Bill " +
													"where Day(DateBill) between " + arr[0]+" and " + arr[1] +" and Month(DateBill) = "+i+" " +
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
			string[] arrs = mon(cbDay.SelectedItem.ToString());
			Graphics.Series.Clear();
			Graphics.Series.Add(series);
			dt = dataPro.DataRead("Select BookName, Sum(Amount) as SL " +
								"from Book inner join BillDetail on Book.BookID = BillDetail.BookID " +
								"inner join Bill on Bill.BillID = BillDetail.BillID " +
								"where Day(DateBill) between " + arrs[0] +" and " + arrs[1] +" and Month(DateBill) = "+cbMonth.Text+" " +
								"group by BookName");
			Label lbBookName = new Label();
			Label lbSL = new Label();
			lbSL.AutoSize = false;
			lbSL.Width = 150;
			lbBookName.Text = "Tên sách";
			lbBookName.ForeColor = Color.Red;
			lbSL.Text = "Số lượng bán";
			lbSL.ForeColor = Color.Red;
			table.Controls.Add(lbBookName);
			table.Controls.Add(lbSL);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				Label lbName = new Label();
				Label lbAmount = new Label();
				lbName.Text = dt.Rows[i]["BookName"].ToString();
				lbAmount.Text = dt.Rows[i]["SL"].ToString();
				table.Controls.Add(lbName);
				table.Controls.Add(lbAmount);
				table.ColumnCount = dt.Rows.Count;
			}
		}

		private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt = dataPro.DataRead("Select months.month as Thang, ISNULL(SUM(TotalBill),0) as Tong " +
				"from ( SELECT 1 AS month UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12) as months " +
				"left join Bill on months.month = MONTH(DateBill) " +
				"where Status = 1 and Year(DateBill) = '" + cbYear.Text + "' group by months.month");
			Series series = new Series("Series1");
			series.ChartType = SeriesChartType.Column;
			if (dt.Rows.Count == 0)
			{
				for (int i = 1; i <= 12; i++)
				{
					DataPoint point = new DataPoint(i, 0);
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
							DataPoint point = new DataPoint(i, dt.Rows[z]["Tong"].ToString());
							series.Points.Add(point);
						}
					}
				}
			}
			Graphics.Series.Clear();
			Graphics.Series.Add(series);
		}


	}
}
