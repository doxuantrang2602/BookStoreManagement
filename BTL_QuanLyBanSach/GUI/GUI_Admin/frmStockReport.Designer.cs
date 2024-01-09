namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
	partial class frmStockReport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.dtgv_SoSachTon = new Guna.UI2.WinForms.Guna2DataGridView();
			this.gr_ThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
			this.pn_Tim = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btn_BaoCaoTonKho = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cb_Nam = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cb_Thang = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cb_Ngay = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.chartThongKeTonKho = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_SoSachTon)).BeginInit();
			this.gr_ThongTin.SuspendLayout();
			this.pn_Tim.SuspendLayout();
			this.guna2GradientPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartThongKeTonKho)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
			this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Blue;
			this.guna2GradientPanel1.BorderThickness = 1;
			this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
			this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.SteelBlue;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(1147, 66);
			this.guna2GradientPanel1.TabIndex = 7;
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(416, 16);
			this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(341, 40);
			this.guna2HtmlLabel2.TabIndex = 1;
			this.guna2HtmlLabel2.Text = "Biểu Đồ Báo Cáo Kho";
			// 
			// dtgv_SoSachTon
			// 
			this.dtgv_SoSachTon.AllowUserToAddRows = false;
			this.dtgv_SoSachTon.AllowUserToResizeColumns = false;
			this.dtgv_SoSachTon.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dtgv_SoSachTon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgv_SoSachTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dtgv_SoSachTon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv_SoSachTon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtgv_SoSachTon.ColumnHeadersHeight = 30;
			this.dtgv_SoSachTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgv_SoSachTon.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtgv_SoSachTon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgv_SoSachTon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtgv_SoSachTon.Location = new System.Drawing.Point(0, 40);
			this.dtgv_SoSachTon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtgv_SoSachTon.Name = "dtgv_SoSachTon";
			this.dtgv_SoSachTon.RowHeadersVisible = false;
			this.dtgv_SoSachTon.RowHeadersWidth = 51;
			this.dtgv_SoSachTon.RowTemplate.Height = 30;
			this.dtgv_SoSachTon.Size = new System.Drawing.Size(1147, 200);
			this.dtgv_SoSachTon.TabIndex = 1;
			this.dtgv_SoSachTon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dtgv_SoSachTon.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dtgv_SoSachTon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dtgv_SoSachTon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dtgv_SoSachTon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dtgv_SoSachTon.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dtgv_SoSachTon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtgv_SoSachTon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.dtgv_SoSachTon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dtgv_SoSachTon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgv_SoSachTon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dtgv_SoSachTon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dtgv_SoSachTon.ThemeStyle.HeaderStyle.Height = 30;
			this.dtgv_SoSachTon.ThemeStyle.ReadOnly = false;
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.Height = 30;
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
			this.dtgv_SoSachTon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// gr_ThongTin
			// 
			this.gr_ThongTin.BorderColor = System.Drawing.Color.Blue;
			this.gr_ThongTin.BorderThickness = 2;
			this.gr_ThongTin.Controls.Add(this.dtgv_SoSachTon);
			this.gr_ThongTin.CustomBorderColor = System.Drawing.SystemColors.Info;
			this.gr_ThongTin.Dock = System.Windows.Forms.DockStyle.Top;
			this.gr_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gr_ThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.gr_ThongTin.Location = new System.Drawing.Point(0, 66);
			this.gr_ThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gr_ThongTin.Name = "gr_ThongTin";
			this.gr_ThongTin.Size = new System.Drawing.Size(1147, 240);
			this.gr_ThongTin.TabIndex = 56;
			this.gr_ThongTin.Text = "Số lượng sách tồn";
			// 
			// pn_Tim
			// 
			this.pn_Tim.BorderColor = System.Drawing.Color.Blue;
			this.pn_Tim.BorderThickness = 1;
			this.pn_Tim.Controls.Add(this.btn_BaoCaoTonKho);
			this.pn_Tim.Controls.Add(this.guna2HtmlLabel3);
			this.pn_Tim.Controls.Add(this.cb_Nam);
			this.pn_Tim.Controls.Add(this.guna2HtmlLabel1);
			this.pn_Tim.Controls.Add(this.cb_Thang);
			this.pn_Tim.Controls.Add(this.guna2HtmlLabel7);
			this.pn_Tim.Controls.Add(this.cb_Ngay);
			this.pn_Tim.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_Tim.FillColor = System.Drawing.Color.SteelBlue;
			this.pn_Tim.Location = new System.Drawing.Point(0, 306);
			this.pn_Tim.Name = "pn_Tim";
			this.pn_Tim.Size = new System.Drawing.Size(1147, 66);
			this.pn_Tim.TabIndex = 57;
			// 
			// btn_BaoCaoTonKho
			// 
			this.btn_BaoCaoTonKho.BackColor = System.Drawing.Color.Transparent;
			this.btn_BaoCaoTonKho.BorderRadius = 15;
			this.btn_BaoCaoTonKho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_BaoCaoTonKho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_BaoCaoTonKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_BaoCaoTonKho.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_BaoCaoTonKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_BaoCaoTonKho.FillColor = System.Drawing.Color.Teal;
			this.btn_BaoCaoTonKho.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_BaoCaoTonKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btn_BaoCaoTonKho.ForeColor = System.Drawing.Color.White;
			this.btn_BaoCaoTonKho.Location = new System.Drawing.Point(946, 12);
			this.btn_BaoCaoTonKho.Name = "btn_BaoCaoTonKho";
			this.btn_BaoCaoTonKho.Size = new System.Drawing.Size(157, 41);
			this.btn_BaoCaoTonKho.TabIndex = 17;
			this.btn_BaoCaoTonKho.Text = "Báo cáo năm";
			this.btn_BaoCaoTonKho.Click += new System.EventHandler(this.btn_BaoCaoTonKho_Click);
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(605, 17);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(50, 28);
			this.guna2HtmlLabel3.TabIndex = 14;
			this.guna2HtmlLabel3.Text = "Năm";
			// 
			// cb_Nam
			// 
			this.cb_Nam.BackColor = System.Drawing.Color.Transparent;
			this.cb_Nam.BorderColor = System.Drawing.Color.Black;
			this.cb_Nam.BorderRadius = 15;
			this.cb_Nam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cb_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Nam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Nam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Nam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cb_Nam.ItemHeight = 30;
			this.cb_Nam.Location = new System.Drawing.Point(661, 17);
			this.cb_Nam.Name = "cb_Nam";
			this.cb_Nam.Size = new System.Drawing.Size(164, 36);
			this.cb_Nam.TabIndex = 11;
			this.cb_Nam.SelectedIndexChanged += new System.EventHandler(this.cb_Nam_SelectedIndexChanged);
			this.cb_Nam.Click += new System.EventHandler(this.cb_Nam_Click);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(330, 17);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 28);
			this.guna2HtmlLabel1.TabIndex = 15;
			this.guna2HtmlLabel1.Text = "Tháng";
			// 
			// cb_Thang
			// 
			this.cb_Thang.BackColor = System.Drawing.Color.Transparent;
			this.cb_Thang.BorderColor = System.Drawing.Color.Black;
			this.cb_Thang.BorderRadius = 15;
			this.cb_Thang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cb_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Thang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Thang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Thang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.cb_Thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cb_Thang.ItemHeight = 30;
			this.cb_Thang.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.cb_Thang.Location = new System.Drawing.Point(399, 17);
			this.cb_Thang.Name = "cb_Thang";
			this.cb_Thang.Size = new System.Drawing.Size(159, 36);
			this.cb_Thang.TabIndex = 12;
			this.cb_Thang.SelectedIndexChanged += new System.EventHandler(this.cb_Thang_SelectedIndexChanged);
			// 
			// guna2HtmlLabel7
			// 
			this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel7.Location = new System.Drawing.Point(69, 17);
			this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			this.guna2HtmlLabel7.Size = new System.Drawing.Size(54, 28);
			this.guna2HtmlLabel7.TabIndex = 16;
			this.guna2HtmlLabel7.Text = "Ngày";
			// 
			// cb_Ngay
			// 
			this.cb_Ngay.BackColor = System.Drawing.Color.Transparent;
			this.cb_Ngay.BorderColor = System.Drawing.Color.Black;
			this.cb_Ngay.BorderRadius = 15;
			this.cb_Ngay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cb_Ngay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Ngay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Ngay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_Ngay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_Ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cb_Ngay.ItemHeight = 30;
			this.cb_Ngay.Location = new System.Drawing.Point(129, 17);
			this.cb_Ngay.Name = "cb_Ngay";
			this.cb_Ngay.Size = new System.Drawing.Size(155, 36);
			this.cb_Ngay.TabIndex = 13;
			this.cb_Ngay.SelectedIndexChanged += new System.EventHandler(this.cb_Ngay_SelectedIndexChanged);
			// 
			// guna2GradientPanel2
			// 
			this.guna2GradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel2.BorderThickness = 1;
			this.guna2GradientPanel2.Controls.Add(this.chartThongKeTonKho);
			this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 372);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new System.Drawing.Size(1147, 475);
			this.guna2GradientPanel2.TabIndex = 58;
			// 
			// chartThongKeTonKho
			// 
			this.chartThongKeTonKho.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			chartArea1.Name = "ChartArea1";
			this.chartThongKeTonKho.ChartAreas.Add(chartArea1);
			this.chartThongKeTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chartThongKeTonKho.Legends.Add(legend1);
			this.chartThongKeTonKho.Location = new System.Drawing.Point(0, 0);
			this.chartThongKeTonKho.Name = "chartThongKeTonKho";
			this.chartThongKeTonKho.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartThongKeTonKho.Series.Add(series1);
			this.chartThongKeTonKho.Size = new System.Drawing.Size(1147, 475);
			this.chartThongKeTonKho.TabIndex = 56;
			this.chartThongKeTonKho.Text = "Biểu đồ tồn kho";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã sách";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "BookName";
			this.Column5.HeaderText = "Tên sách";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Tổng số lượng bán";
			this.Column1.HeaderText = "Tổng số lượng bán";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Tổng số lượng nhập";
			this.Column2.HeaderText = "Tổng số lượng nhập";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Số lượng tồn";
			this.Column3.HeaderText = "Số lượng tồn";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Trị giá tồn kho";
			this.Column4.HeaderText = "Trị giá tồn kho";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			// 
			// frmStockReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1147, 847);
			this.Controls.Add(this.guna2GradientPanel2);
			this.Controls.Add(this.pn_Tim);
			this.Controls.Add(this.gr_ThongTin);
			this.Controls.Add(this.guna2GradientPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmStockReport";
			this.Text = "frm_StockReport";
			this.Load += new System.EventHandler(this.frmStockReport_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_SoSachTon)).EndInit();
			this.gr_ThongTin.ResumeLayout(false);
			this.pn_Tim.ResumeLayout(false);
			this.pn_Tim.PerformLayout();
			this.guna2GradientPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartThongKeTonKho)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2DataGridView dtgv_SoSachTon;
		private Guna.UI2.WinForms.Guna2GroupBox gr_ThongTin;
		private Guna.UI2.WinForms.Guna2GradientPanel pn_Tim;
		private Guna.UI2.WinForms.Guna2GradientButton btn_BaoCaoTonKho;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
		public Guna.UI2.WinForms.Guna2ComboBox cb_Nam;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		public Guna.UI2.WinForms.Guna2ComboBox cb_Thang;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
		public Guna.UI2.WinForms.Guna2ComboBox cb_Ngay;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeTonKho;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
	}
}