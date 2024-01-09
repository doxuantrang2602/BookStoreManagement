namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    partial class frmEmployee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gr_NhanVien = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Tim = new Guna.UI2.WinForms.Guna2Button();
			this.txb_TuKhoa = new Guna.UI2.WinForms.Guna2TextBox();
			this.cb_ChucVu1 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtgv_NhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
			this.ctmn_NhanVien = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ctmn_Them = new System.Windows.Forms.ToolStripMenuItem();
			this.ctmn_Xoa = new System.Windows.Forms.ToolStripMenuItem();
			this.ctmn_Sua = new System.Windows.Forms.ToolStripMenuItem();
			this.ctmn_Xem = new System.Windows.Forms.ToolStripMenuItem();
			this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.btn_InDS = new Guna.UI2.WinForms.Guna2Button();
			this.btn_XuatExcel = new Guna.UI2.WinForms.Guna2Button();
			this.lbl_Ngay = new System.Windows.Forms.Label();
			this.lbl_TongNV = new System.Windows.Forms.Label();
			this.lbl_Admin = new System.Windows.Forms.Label();
			this.gr_NhanVien.SuspendLayout();
			this.guna2GradientPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).BeginInit();
			this.ctmn_NhanVien.SuspendLayout();
			this.guna2GradientPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gr_NhanVien
			// 
			this.gr_NhanVien.Controls.Add(this.guna2GradientPanel1);
			this.gr_NhanVien.Controls.Add(this.dtgv_NhanVien);
			this.gr_NhanVien.CustomBorderColor = System.Drawing.Color.SteelBlue;
			this.gr_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.gr_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gr_NhanVien.ForeColor = System.Drawing.Color.White;
			this.gr_NhanVien.Location = new System.Drawing.Point(0, 0);
			this.gr_NhanVien.Name = "gr_NhanVien";
			this.gr_NhanVien.Size = new System.Drawing.Size(1219, 577);
			this.gr_NhanVien.TabIndex = 0;
			this.gr_NhanVien.Text = "Thông tin Nhân viên";
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
			this.guna2GradientPanel1.Controls.Add(this.btn_Huy);
			this.guna2GradientPanel1.Controls.Add(this.btn_Tim);
			this.guna2GradientPanel1.Controls.Add(this.txb_TuKhoa);
			this.guna2GradientPanel1.Controls.Add(this.cb_ChucVu1);
			this.guna2GradientPanel1.Controls.Add(this.label1);
			this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 40);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(1219, 97);
			this.guna2GradientPanel1.TabIndex = 1;
			// 
			// btn_Huy
			// 
			this.btn_Huy.BorderRadius = 15;
			this.btn_Huy.BorderThickness = 1;
			this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Huy.FillColor = System.Drawing.Color.White;
			this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_Huy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
			this.btn_Huy.Location = new System.Drawing.Point(998, 36);
			this.btn_Huy.Name = "btn_Huy";
			this.btn_Huy.Size = new System.Drawing.Size(94, 36);
			this.btn_Huy.TabIndex = 3;
			this.btn_Huy.Text = "Hủy";
			this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
			// 
			// btn_Tim
			// 
			this.btn_Tim.BorderRadius = 15;
			this.btn_Tim.BorderThickness = 1;
			this.btn_Tim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Tim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Tim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Tim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Tim.FillColor = System.Drawing.Color.White;
			this.btn_Tim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_Tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_Tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim.Image")));
			this.btn_Tim.Location = new System.Drawing.Point(808, 36);
			this.btn_Tim.Name = "btn_Tim";
			this.btn_Tim.Size = new System.Drawing.Size(131, 36);
			this.btn_Tim.TabIndex = 3;
			this.btn_Tim.Text = "Tìm kiếm";
			this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
			// 
			// txb_TuKhoa
			// 
			this.txb_TuKhoa.BorderColor = System.Drawing.Color.Black;
			this.txb_TuKhoa.BorderRadius = 15;
			this.txb_TuKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txb_TuKhoa.DefaultText = "";
			this.txb_TuKhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txb_TuKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txb_TuKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txb_TuKhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txb_TuKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txb_TuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txb_TuKhoa.ForeColor = System.Drawing.Color.Black;
			this.txb_TuKhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txb_TuKhoa.Location = new System.Drawing.Point(561, 36);
			this.txb_TuKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txb_TuKhoa.Name = "txb_TuKhoa";
			this.txb_TuKhoa.PasswordChar = '\0';
			this.txb_TuKhoa.PlaceholderText = "";
			this.txb_TuKhoa.SelectedText = "";
			this.txb_TuKhoa.Size = new System.Drawing.Size(228, 36);
			this.txb_TuKhoa.TabIndex = 2;
			// 
			// cb_ChucVu1
			// 
			this.cb_ChucVu1.BackColor = System.Drawing.Color.Transparent;
			this.cb_ChucVu1.BorderColor = System.Drawing.Color.Black;
			this.cb_ChucVu1.BorderRadius = 15;
			this.cb_ChucVu1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cb_ChucVu1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_ChucVu1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_ChucVu1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cb_ChucVu1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_ChucVu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.cb_ChucVu1.ItemHeight = 30;
			this.cb_ChucVu1.Location = new System.Drawing.Point(137, 36);
			this.cb_ChucVu1.Name = "cb_ChucVu1";
			this.cb_ChucVu1.Size = new System.Drawing.Size(202, 36);
			this.cb_ChucVu1.TabIndex = 1;
			this.cb_ChucVu1.SelectedIndexChanged += new System.EventHandler(this.cb_ChucVu1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(54, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chức vụ";
			// 
			// dtgv_NhanVien
			// 
			this.dtgv_NhanVien.AllowUserToAddRows = false;
			this.dtgv_NhanVien.AllowUserToDeleteRows = false;
			this.dtgv_NhanVien.AllowUserToResizeColumns = false;
			this.dtgv_NhanVien.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dtgv_NhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dtgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dtgv_NhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dtgv_NhanVien.ColumnHeadersHeight = 40;
			this.dtgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
			this.dtgv_NhanVien.ContextMenuStrip = this.ctmn_NhanVien;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle6;
			this.dtgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dtgv_NhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtgv_NhanVien.Location = new System.Drawing.Point(0, 135);
			this.dtgv_NhanVien.Name = "dtgv_NhanVien";
			this.dtgv_NhanVien.RowHeadersVisible = false;
			this.dtgv_NhanVien.RowHeadersWidth = 51;
			this.dtgv_NhanVien.RowTemplate.Height = 80;
			this.dtgv_NhanVien.Size = new System.Drawing.Size(1219, 442);
			this.dtgv_NhanVien.TabIndex = 0;
			this.dtgv_NhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dtgv_NhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dtgv_NhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dtgv_NhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dtgv_NhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dtgv_NhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dtgv_NhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dtgv_NhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.dtgv_NhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtgv_NhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgv_NhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.dtgv_NhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dtgv_NhanVien.ThemeStyle.HeaderStyle.Height = 40;
			this.dtgv_NhanVien.ThemeStyle.ReadOnly = false;
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.Height = 80;
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Teal;
			this.dtgv_NhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			this.dtgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NhanVien_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "EmployeeID";
			this.Column1.HeaderText = "Mã nhân viên";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "FullName";
			this.Column2.HeaderText = "Họ và tên";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "DateOfBirth";
			this.Column3.HeaderText = "Ngày sinh";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Address";
			this.Column4.HeaderText = "Địa chỉ";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Email";
			this.Column5.HeaderText = "Email";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "PhoneNumber";
			this.Column6.HeaderText = "Số điện thoại";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "StartWorkDate";
			this.Column7.HeaderText = "Ngày vào làm";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "RoleName";
			this.Column8.HeaderText = "Chức vụ";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "Picture";
			this.Column9.HeaderText = "Ảnh đại diện";
			this.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// ctmn_NhanVien
			// 
			this.ctmn_NhanVien.BackColor = System.Drawing.Color.White;
			this.ctmn_NhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ctmn_NhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmn_Them,
            this.ctmn_Xoa,
            this.ctmn_Sua,
            this.ctmn_Xem});
			this.ctmn_NhanVien.Name = "ctmn_NhanVien";
			this.ctmn_NhanVien.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.ctmn_NhanVien.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.ctmn_NhanVien.RenderStyle.ColorTable = null;
			this.ctmn_NhanVien.RenderStyle.RoundedEdges = true;
			this.ctmn_NhanVien.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.ctmn_NhanVien.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ctmn_NhanVien.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.ctmn_NhanVien.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.ctmn_NhanVien.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ctmn_NhanVien.Size = new System.Drawing.Size(177, 108);
			// 
			// ctmn_Them
			// 
			this.ctmn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctmn_Them.ForeColor = System.Drawing.Color.Black;
			this.ctmn_Them.Image = ((System.Drawing.Image)(resources.GetObject("ctmn_Them.Image")));
			this.ctmn_Them.Name = "ctmn_Them";
			this.ctmn_Them.Size = new System.Drawing.Size(176, 26);
			this.ctmn_Them.Text = "Thêm";
			this.ctmn_Them.Click += new System.EventHandler(this.ctmn_Them_Click);
			// 
			// ctmn_Xoa
			// 
			this.ctmn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctmn_Xoa.ForeColor = System.Drawing.Color.Black;
			this.ctmn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("ctmn_Xoa.Image")));
			this.ctmn_Xoa.Name = "ctmn_Xoa";
			this.ctmn_Xoa.Size = new System.Drawing.Size(176, 26);
			this.ctmn_Xoa.Text = "Xóa ";
			this.ctmn_Xoa.Click += new System.EventHandler(this.ctmn_Xoa_Click);
			// 
			// ctmn_Sua
			// 
			this.ctmn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctmn_Sua.ForeColor = System.Drawing.Color.Black;
			this.ctmn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("ctmn_Sua.Image")));
			this.ctmn_Sua.Name = "ctmn_Sua";
			this.ctmn_Sua.Size = new System.Drawing.Size(176, 26);
			this.ctmn_Sua.Text = "Sửa";
			this.ctmn_Sua.Click += new System.EventHandler(this.ctmn_Sua_Click);
			// 
			// ctmn_Xem
			// 
			this.ctmn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctmn_Xem.ForeColor = System.Drawing.Color.Black;
			this.ctmn_Xem.Image = ((System.Drawing.Image)(resources.GetObject("ctmn_Xem.Image")));
			this.ctmn_Xem.Name = "ctmn_Xem";
			this.ctmn_Xem.Size = new System.Drawing.Size(176, 26);
			this.ctmn_Xem.Text = "Xem chi tiết";
			this.ctmn_Xem.Click += new System.EventHandler(this.ctmn_Xem_Click);
			// 
			// guna2GradientPanel2
			// 
			this.guna2GradientPanel2.BackColor = System.Drawing.Color.White;
			this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Black;
			this.guna2GradientPanel2.BorderThickness = 1;
			this.guna2GradientPanel2.Controls.Add(this.btn_InDS);
			this.guna2GradientPanel2.Controls.Add(this.btn_XuatExcel);
			this.guna2GradientPanel2.Controls.Add(this.lbl_Ngay);
			this.guna2GradientPanel2.Controls.Add(this.lbl_TongNV);
			this.guna2GradientPanel2.Controls.Add(this.lbl_Admin);
			this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 577);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new System.Drawing.Size(1219, 153);
			this.guna2GradientPanel2.TabIndex = 1;
			// 
			// btn_InDS
			// 
			this.btn_InDS.BorderRadius = 15;
			this.btn_InDS.BorderThickness = 1;
			this.btn_InDS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_InDS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_InDS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_InDS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_InDS.FillColor = System.Drawing.Color.White;
			this.btn_InDS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_InDS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_InDS.Image = ((System.Drawing.Image)(resources.GetObject("btn_InDS.Image")));
			this.btn_InDS.Location = new System.Drawing.Point(900, 25);
			this.btn_InDS.Name = "btn_InDS";
			this.btn_InDS.Size = new System.Drawing.Size(146, 36);
			this.btn_InDS.TabIndex = 3;
			this.btn_InDS.Text = "In danh sách";
			this.btn_InDS.Click += new System.EventHandler(this.btn_InDS_Click);
			// 
			// btn_XuatExcel
			// 
			this.btn_XuatExcel.BorderRadius = 15;
			this.btn_XuatExcel.BorderThickness = 1;
			this.btn_XuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_XuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_XuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_XuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_XuatExcel.FillColor = System.Drawing.Color.White;
			this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
			this.btn_XuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btn_XuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_XuatExcel.Image")));
			this.btn_XuatExcel.Location = new System.Drawing.Point(1060, 25);
			this.btn_XuatExcel.Name = "btn_XuatExcel";
			this.btn_XuatExcel.Size = new System.Drawing.Size(131, 36);
			this.btn_XuatExcel.TabIndex = 3;
			this.btn_XuatExcel.Text = "Xuất Excel";
			this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
			// 
			// lbl_Ngay
			// 
			this.lbl_Ngay.AutoSize = true;
			this.lbl_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Ngay.ForeColor = System.Drawing.Color.Black;
			this.lbl_Ngay.Location = new System.Drawing.Point(35, 103);
			this.lbl_Ngay.Name = "lbl_Ngay";
			this.lbl_Ngay.Size = new System.Drawing.Size(64, 25);
			this.lbl_Ngay.TabIndex = 0;
			this.lbl_Ngay.Text = "Ngày:";
			// 
			// lbl_TongNV
			// 
			this.lbl_TongNV.AutoSize = true;
			this.lbl_TongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_TongNV.ForeColor = System.Drawing.Color.Black;
			this.lbl_TongNV.Location = new System.Drawing.Point(35, 68);
			this.lbl_TongNV.Name = "lbl_TongNV";
			this.lbl_TongNV.Size = new System.Drawing.Size(165, 25);
			this.lbl_TongNV.TabIndex = 0;
			this.lbl_TongNV.Text = "Tổng số nhân sự:";
			// 
			// lbl_Admin
			// 
			this.lbl_Admin.AutoSize = true;
			this.lbl_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Admin.ForeColor = System.Drawing.Color.Black;
			this.lbl_Admin.Location = new System.Drawing.Point(35, 25);
			this.lbl_Admin.Name = "lbl_Admin";
			this.lbl_Admin.Size = new System.Drawing.Size(74, 25);
			this.lbl_Admin.TabIndex = 0;
			this.lbl_Admin.Text = "Admin:";
			// 
			// frmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1219, 730);
			this.Controls.Add(this.guna2GradientPanel2);
			this.Controls.Add(this.gr_NhanVien);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "frmEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmEmployee";
			this.Load += new System.EventHandler(this.frmEmployee_Load);
			this.gr_NhanVien.ResumeLayout(false);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).EndInit();
			this.ctmn_NhanVien.ResumeLayout(false);
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GroupBox gr_NhanVien;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_NhanVien;
        public Guna.UI2.WinForms.Guna2ContextMenuStrip ctmn_NhanVien;
        public System.Windows.Forms.ToolStripMenuItem ctmn_Them;
        public System.Windows.Forms.ToolStripMenuItem ctmn_Xoa;
        public System.Windows.Forms.ToolStripMenuItem ctmn_Sua;
        public System.Windows.Forms.ToolStripMenuItem ctmn_Xem;
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ComboBox cb_ChucVu1;
        public Guna.UI2.WinForms.Guna2Button btn_Tim;
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        public System.Windows.Forms.Label lbl_Admin;
        public System.Windows.Forms.Label lbl_TongNV;
        public Guna.UI2.WinForms.Guna2Button btn_InDS;
        public Guna.UI2.WinForms.Guna2Button btn_XuatExcel;
        public System.Windows.Forms.Label lbl_Ngay;
        public Guna.UI2.WinForms.Guna2Button btn_Huy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        public Guna.UI2.WinForms.Guna2TextBox txb_TuKhoa;
    }
}