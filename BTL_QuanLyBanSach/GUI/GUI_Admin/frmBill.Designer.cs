namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
	partial class frmBill
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.flowBillID = new System.Windows.Forms.FlowLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtTotalBill = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtBillID = new Guna.UI2.WinForms.Guna2TextBox();
			this.DateBill = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtEmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataViewDetailBill = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Print = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.txtSearchBillID = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2GradientPanel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViewDetailBill)).BeginInit();
			this.guna2GradientPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
			this.guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel1.BorderThickness = 1;
			this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
			this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2GradientPanel1.FillColor = System.Drawing.Color.Lavender;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(1232, 71);
			this.guna2GradientPanel1.TabIndex = 0;
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(410, 13);
			this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(477, 40);
			this.guna2HtmlLabel2.TabIndex = 2;
			this.guna2HtmlLabel2.Text = "Danh Sách Hóa Đơn Bán hàng";
			// 
			// flowBillID
			// 
			this.flowBillID.AutoScroll = true;
			this.flowBillID.BackColor = System.Drawing.Color.White;
			this.flowBillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowBillID.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowBillID.Location = new System.Drawing.Point(957, 71);
			this.flowBillID.Margin = new System.Windows.Forms.Padding(4);
			this.flowBillID.Name = "flowBillID";
			this.flowBillID.Size = new System.Drawing.Size(275, 654);
			this.flowBillID.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Controls.Add(this.txtTotalBill);
			this.panel5.Controls.Add(this.txtBillID);
			this.panel5.Controls.Add(this.DateBill);
			this.panel5.Controls.Add(this.txtFullName);
			this.panel5.Controls.Add(this.txtEmployeeID);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.label14);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 71);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(957, 178);
			this.panel5.TabIndex = 4;
			// 
			// txtTotalBill
			// 
			this.txtTotalBill.BackColor = System.Drawing.Color.Transparent;
			this.txtTotalBill.BorderColor = System.Drawing.Color.Black;
			this.txtTotalBill.BorderRadius = 15;
			this.txtTotalBill.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTotalBill.DefaultText = "";
			this.txtTotalBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTotalBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTotalBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTotalBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTotalBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTotalBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalBill.ForeColor = System.Drawing.Color.Black;
			this.txtTotalBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTotalBill.Location = new System.Drawing.Point(629, 82);
			this.txtTotalBill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtTotalBill.Name = "txtTotalBill";
			this.txtTotalBill.PasswordChar = '\0';
			this.txtTotalBill.PlaceholderText = "";
			this.txtTotalBill.SelectedText = "";
			this.txtTotalBill.Size = new System.Drawing.Size(241, 33);
			this.txtTotalBill.TabIndex = 62;
			// 
			// txtBillID
			// 
			this.txtBillID.BackColor = System.Drawing.Color.Transparent;
			this.txtBillID.BorderColor = System.Drawing.Color.Black;
			this.txtBillID.BorderRadius = 15;
			this.txtBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBillID.DefaultText = "";
			this.txtBillID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtBillID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtBillID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBillID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBillID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBillID.ForeColor = System.Drawing.Color.Black;
			this.txtBillID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBillID.Location = new System.Drawing.Point(188, 132);
			this.txtBillID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtBillID.Name = "txtBillID";
			this.txtBillID.PasswordChar = '\0';
			this.txtBillID.PlaceholderText = "";
			this.txtBillID.SelectedText = "";
			this.txtBillID.Size = new System.Drawing.Size(235, 32);
			this.txtBillID.TabIndex = 62;
			// 
			// DateBill
			// 
			this.DateBill.BackColor = System.Drawing.Color.Transparent;
			this.DateBill.BorderColor = System.Drawing.Color.Black;
			this.DateBill.BorderRadius = 15;
			this.DateBill.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.DateBill.DefaultText = "";
			this.DateBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.DateBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.DateBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.DateBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.DateBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.DateBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateBill.ForeColor = System.Drawing.Color.Black;
			this.DateBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.DateBill.Location = new System.Drawing.Point(188, 25);
			this.DateBill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.DateBill.Name = "DateBill";
			this.DateBill.PasswordChar = '\0';
			this.DateBill.PlaceholderText = "";
			this.DateBill.SelectedText = "";
			this.DateBill.Size = new System.Drawing.Size(235, 33);
			this.DateBill.TabIndex = 62;
			// 
			// txtFullName
			// 
			this.txtFullName.BackColor = System.Drawing.Color.Transparent;
			this.txtFullName.BorderColor = System.Drawing.Color.Black;
			this.txtFullName.BorderRadius = 15;
			this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFullName.DefaultText = "";
			this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullName.ForeColor = System.Drawing.Color.Black;
			this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFullName.Location = new System.Drawing.Point(188, 82);
			this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.PasswordChar = '\0';
			this.txtFullName.PlaceholderText = "";
			this.txtFullName.SelectedText = "";
			this.txtFullName.Size = new System.Drawing.Size(235, 33);
			this.txtFullName.TabIndex = 62;
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.BackColor = System.Drawing.Color.Transparent;
			this.txtEmployeeID.BorderColor = System.Drawing.Color.Black;
			this.txtEmployeeID.BorderRadius = 15;
			this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmployeeID.DefaultText = "";
			this.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmployeeID.ForeColor = System.Drawing.Color.Black;
			this.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmployeeID.Location = new System.Drawing.Point(629, 25);
			this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.PasswordChar = '\0';
			this.txtEmployeeID.PlaceholderText = "";
			this.txtEmployeeID.SelectedText = "";
			this.txtEmployeeID.Size = new System.Drawing.Size(241, 33);
			this.txtEmployeeID.TabIndex = 62;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 130);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(183, 34);
			this.label5.TabIndex = 53;
			this.label5.Text = "Mã hóa đơn : ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(483, 75);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(116, 34);
			this.label14.TabIndex = 42;
			this.label14.Text = "Tổng tiền :";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(481, 20);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 34);
			this.label4.TabIndex = 38;
			this.label4.Text = "Mã nhân viên :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 34);
			this.label2.TabIndex = 36;
			this.label2.Text = "Tên khách hàng :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 20);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 34);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ngày bán :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataViewDetailBill
			// 
			this.dataViewDetailBill.AllowUserToAddRows = false;
			this.dataViewDetailBill.AllowUserToResizeColumns = false;
			this.dataViewDetailBill.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataViewDetailBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataViewDetailBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataViewDetailBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.dataViewDetailBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViewDetailBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataViewDetailBill.ColumnHeadersHeight = 35;
			this.dataViewDetailBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataViewDetailBill.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataViewDetailBill.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataViewDetailBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataViewDetailBill.Location = new System.Drawing.Point(0, 249);
			this.dataViewDetailBill.Margin = new System.Windows.Forms.Padding(4);
			this.dataViewDetailBill.Name = "dataViewDetailBill";
			this.dataViewDetailBill.ReadOnly = true;
			this.dataViewDetailBill.RowHeadersVisible = false;
			this.dataViewDetailBill.RowHeadersWidth = 51;
			this.dataViewDetailBill.RowTemplate.Height = 30;
			this.dataViewDetailBill.RowTemplate.ReadOnly = true;
			this.dataViewDetailBill.Size = new System.Drawing.Size(957, 259);
			this.dataViewDetailBill.TabIndex = 50;
			this.dataViewDetailBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataViewDetailBill.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataViewDetailBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataViewDetailBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataViewDetailBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataViewDetailBill.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataViewDetailBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataViewDetailBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
			this.dataViewDetailBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataViewDetailBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataViewDetailBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataViewDetailBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataViewDetailBill.ThemeStyle.HeaderStyle.Height = 35;
			this.dataViewDetailBill.ThemeStyle.ReadOnly = true;
			this.dataViewDetailBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataViewDetailBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.dataViewDetailBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataViewDetailBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.dataViewDetailBill.ThemeStyle.RowsStyle.Height = 30;
			this.dataViewDetailBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
			this.dataViewDetailBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "BookID";
			this.Column1.HeaderText = "Mã sách";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Price";
			this.Column2.HeaderText = "Đơn giá bán";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Amount";
			this.Column3.HeaderText = "Số lượng bán";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Discount";
			this.Column4.HeaderText = "Giảm giá";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "TotalCost";
			this.Column5.HeaderText = "Thành tiền";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// btn_Print
			// 
			this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Print.BackColor = System.Drawing.Color.Transparent;
			this.btn_Print.BorderRadius = 15;
			this.btn_Print.BorderThickness = 1;
			this.btn_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Print.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(140)))), ((int)(((byte)(209)))));
			this.btn_Print.FillColor2 = System.Drawing.Color.Teal;
			this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Print.ForeColor = System.Drawing.Color.White;
			this.btn_Print.Location = new System.Drawing.Point(577, 99);
			this.btn_Print.Name = "btn_Print";
			this.btn_Print.Size = new System.Drawing.Size(153, 46);
			this.btn_Print.TabIndex = 56;
			this.btn_Print.Text = "In hóa đơn";
			this.btn_Print.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// guna2GradientPanel2
			// 
			this.guna2GradientPanel2.BackColor = System.Drawing.Color.White;
			this.guna2GradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.guna2GradientPanel2.BorderThickness = 1;
			this.guna2GradientPanel2.Controls.Add(this.btn_Huy);
			this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel1);
			this.guna2GradientPanel2.Controls.Add(this.btn_Print);
			this.guna2GradientPanel2.Controls.Add(this.guna2Button2);
			this.guna2GradientPanel2.Controls.Add(this.txtSearchBillID);
			this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2GradientPanel2.FillColor = System.Drawing.Color.Azure;
			this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 508);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new System.Drawing.Size(957, 217);
			this.guna2GradientPanel2.TabIndex = 57;
			// 
			// btn_Huy
			// 
			this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Huy.BorderRadius = 20;
			this.btn_Huy.BorderThickness = 1;
			this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Huy.FillColor = System.Drawing.Color.White;
			this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btn_Huy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
			this.btn_Huy.Location = new System.Drawing.Point(771, 99);
			this.btn_Huy.Name = "btn_Huy";
			this.btn_Huy.Size = new System.Drawing.Size(116, 46);
			this.btn_Huy.TabIndex = 63;
			this.btn_Huy.Text = "Hủy";
			this.btn_Huy.Click += new System.EventHandler(this.guna2GradientButton1_Click);
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(347, 33);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(141, 31);
			this.guna2HtmlLabel1.TabIndex = 22;
			this.guna2HtmlLabel1.Text = "Mã hóa đơn :";
			// 
			// guna2Button2
			// 
			this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2Button2.BorderRadius = 20;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.White;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
			this.guna2Button2.Location = new System.Drawing.Point(771, 27);
			this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(126, 47);
			this.guna2Button2.TabIndex = 21;
			this.guna2Button2.Text = "Tìm kiếm";
			// 
			// txtSearchBillID
			// 
			this.txtSearchBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSearchBillID.BackColor = System.Drawing.Color.Transparent;
			this.txtSearchBillID.BorderColor = System.Drawing.Color.Black;
			this.txtSearchBillID.BorderRadius = 15;
			this.txtSearchBillID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearchBillID.DefaultText = "";
			this.txtSearchBillID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSearchBillID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSearchBillID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearchBillID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearchBillID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearchBillID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchBillID.ForeColor = System.Drawing.Color.Black;
			this.txtSearchBillID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearchBillID.Location = new System.Drawing.Point(514, 31);
			this.txtSearchBillID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtSearchBillID.Name = "txtSearchBillID";
			this.txtSearchBillID.PasswordChar = '\0';
			this.txtSearchBillID.PlaceholderText = "";
			this.txtSearchBillID.SelectedText = "";
			this.txtSearchBillID.Size = new System.Drawing.Size(235, 33);
			this.txtSearchBillID.TabIndex = 62;
			// 
			// frmBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(1232, 725);
			this.Controls.Add(this.guna2GradientPanel2);
			this.Controls.Add(this.dataViewDetailBill);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.flowBillID);
			this.Controls.Add(this.guna2GradientPanel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBill";
			this.Text = "frmBill";
			this.Load += new System.EventHandler(this.frmBill_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViewDetailBill)).EndInit();
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private System.Windows.Forms.FlowLayoutPanel flowBillID;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2DataGridView dataViewDetailBill;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		public Guna.UI2.WinForms.Guna2GradientButton btn_Print;
		public Guna.UI2.WinForms.Guna2TextBox txtTotalBill;
		public Guna.UI2.WinForms.Guna2TextBox txtBillID;
		public Guna.UI2.WinForms.Guna2TextBox txtFullName;
		public Guna.UI2.WinForms.Guna2TextBox txtEmployeeID;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
		public Guna.UI2.WinForms.Guna2Button guna2Button2;
		public Guna.UI2.WinForms.Guna2TextBox DateBill;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		public Guna.UI2.WinForms.Guna2TextBox txtSearchBillID;
		public Guna.UI2.WinForms.Guna2Button btn_Huy;
	}
}