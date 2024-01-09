namespace BTL.Main.Control
{
    partial class U_LSNH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.Graphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cbYear = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbMonth = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cbDay = new Guna.UI2.WinForms.Guna2ComboBox();
			this.table = new System.Windows.Forms.TableLayoutPanel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Graphics)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(979, 41);
			this.panel2.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(361, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "THỐNG KÊ DOANH THU";
			// 
			// Graphics
			// 
			this.Graphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.Name = "ChartArea1";
			this.Graphics.ChartAreas.Add(chartArea3);
			this.Graphics.Location = new System.Drawing.Point(25, 140);
			this.Graphics.Name = "Graphics";
			series3.ChartArea = "ChartArea1";
			series3.IsXValueIndexed = true;
			series3.Name = "Series1";
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			this.Graphics.Series.Add(series3);
			this.Graphics.Size = new System.Drawing.Size(932, 196);
			this.Graphics.TabIndex = 18;
			this.Graphics.Text = "chart1";
			// 
			// cbYear
			// 
			this.cbYear.BackColor = System.Drawing.Color.Transparent;
			this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbYear.ItemHeight = 24;
			this.cbYear.Location = new System.Drawing.Point(98, 58);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(194, 30);
			this.cbYear.TabIndex = 20;
			this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
			this.cbYear.Click += new System.EventHandler(this.cbYear_Click);
			// 
			// cbMonth
			// 
			this.cbMonth.BackColor = System.Drawing.Color.Transparent;
			this.cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbMonth.ItemHeight = 24;
			this.cbMonth.Items.AddRange(new object[] {
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
			this.cbMonth.Location = new System.Drawing.Point(450, 58);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(184, 30);
			this.cbMonth.TabIndex = 21;
			this.cbMonth.SelectedValueChanged += new System.EventHandler(this.cbMonth_SelectedValueChanged);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.AutoSize = false;
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(25, 58);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(67, 30);
			this.guna2HtmlLabel1.TabIndex = 22;
			this.guna2HtmlLabel1.Text = "Năm : ";
			this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.AutoSize = false;
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(347, 58);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(67, 30);
			this.guna2HtmlLabel2.TabIndex = 23;
			this.guna2HtmlLabel2.Text = "Tháng :";
			this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.AutoSize = false;
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(677, 58);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(67, 30);
			this.guna2HtmlLabel3.TabIndex = 25;
			this.guna2HtmlLabel3.Text = "Ngày :";
			this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbDay
			// 
			this.cbDay.BackColor = System.Drawing.Color.Transparent;
			this.cbDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbDay.ItemHeight = 24;
			this.cbDay.Location = new System.Drawing.Point(773, 58);
			this.cbDay.Name = "cbDay";
			this.cbDay.Size = new System.Drawing.Size(184, 30);
			this.cbDay.TabIndex = 24;
			this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
			// 
			// table
			// 
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.table.ColumnCount = 2;
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.table.Location = new System.Drawing.Point(25, 381);
			this.table.Name = "table";
			this.table.RowCount = 1;
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.table.Size = new System.Drawing.Size(424, 164);
			this.table.TabIndex = 26;
			// 
			// U_LSNH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.table);
			this.Controls.Add(this.guna2HtmlLabel3);
			this.Controls.Add(this.cbDay);
			this.Controls.Add(this.guna2HtmlLabel2);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Controls.Add(this.cbMonth);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.Graphics);
			this.Controls.Add(this.panel2);
			this.Name = "U_LSNH";
			this.Size = new System.Drawing.Size(979, 574);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Graphics)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphics;
        private Guna.UI2.WinForms.Guna2ComboBox cbYear;
        private Guna.UI2.WinForms.Guna2ComboBox cbMonth;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbDay;
		private System.Windows.Forms.TableLayoutPanel table;
	}
}
