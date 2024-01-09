using System.Windows.Forms;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
	partial class FrmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.btn_QuanLySach = new System.Windows.Forms.Button();
			this.btn_TrangChu = new System.Windows.Forms.Button();
			this.btn_KhachHang = new System.Windows.Forms.Button();
			this.btn_NhanVien = new System.Windows.Forms.Button();
			this.DonHangTransition = new System.Windows.Forms.Timer(this.components);
			this.ptb_SideBar = new System.Windows.Forms.PictureBox();
			this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
			this.ptb_Admin = new System.Windows.Forms.PictureBox();
			this.fPanel_Sidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.pn_PictureBox = new System.Windows.Forms.Panel();
			this.fl_PanelDonHang = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_HoaDon = new System.Windows.Forms.Button();
			this.btn_HoaDonBan = new System.Windows.Forms.Button();
			this.btn_HoaDonNhap = new System.Windows.Forms.Button();
			this.fl_Panel_BaoCao = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_BaoCao = new System.Windows.Forms.Button();
			this.btn_BaoCaoBanHang = new System.Windows.Forms.Button();
			this.btn_BaoCaoTonKho = new System.Windows.Forms.Button();
			this.btn_Account = new System.Windows.Forms.Button();
			this.panel_Body = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.lb_Admin = new System.Windows.Forms.Label();
			this.mn_HeThong = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.baoCaoTransition = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ptb_SideBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Admin)).BeginInit();
			this.fPanel_Sidebar.SuspendLayout();
			this.pn_PictureBox.SuspendLayout();
			this.fl_PanelDonHang.SuspendLayout();
			this.fl_Panel_BaoCao.SuspendLayout();
			this.panel_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.guna2GradientPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_QuanLySach
			// 
			this.btn_QuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_QuanLySach.FlatAppearance.BorderSize = 0;
			this.btn_QuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_QuanLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_QuanLySach.ForeColor = System.Drawing.Color.White;
			this.btn_QuanLySach.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuanLySach.Image")));
			this.btn_QuanLySach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_QuanLySach.Location = new System.Drawing.Point(3, 198);
			this.btn_QuanLySach.Name = "btn_QuanLySach";
			this.btn_QuanLySach.Size = new System.Drawing.Size(255, 56);
			this.btn_QuanLySach.TabIndex = 7;
			this.btn_QuanLySach.Text = "Quản Lý Sách";
			this.btn_QuanLySach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_QuanLySach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_QuanLySach.UseVisualStyleBackColor = false;
			this.btn_QuanLySach.Click += new System.EventHandler(this.btn_QuanLySach_Click);
			// 
			// btn_TrangChu
			// 
			this.btn_TrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_TrangChu.FlatAppearance.BorderSize = 0;
			this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_TrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_TrangChu.ForeColor = System.Drawing.Color.White;
			this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
			this.btn_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_TrangChu.Location = new System.Drawing.Point(3, 136);
			this.btn_TrangChu.Name = "btn_TrangChu";
			this.btn_TrangChu.Size = new System.Drawing.Size(255, 56);
			this.btn_TrangChu.TabIndex = 1;
			this.btn_TrangChu.Text = "Trang Chủ";
			this.btn_TrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_TrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_TrangChu.UseVisualStyleBackColor = false;
			this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
			// 
			// btn_KhachHang
			// 
			this.btn_KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_KhachHang.FlatAppearance.BorderSize = 0;
			this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
			this.btn_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Image")));
			this.btn_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_KhachHang.Location = new System.Drawing.Point(3, 260);
			this.btn_KhachHang.Name = "btn_KhachHang";
			this.btn_KhachHang.Size = new System.Drawing.Size(271, 56);
			this.btn_KhachHang.TabIndex = 4;
			this.btn_KhachHang.Text = "Quản Lý Khách Hàng";
			this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_KhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_KhachHang.UseVisualStyleBackColor = false;
			this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
			// 
			// btn_NhanVien
			// 
			this.btn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_NhanVien.FlatAppearance.BorderSize = 0;
			this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NhanVien.ForeColor = System.Drawing.Color.White;
			this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
			this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_NhanVien.Location = new System.Drawing.Point(3, 322);
			this.btn_NhanVien.Name = "btn_NhanVien";
			this.btn_NhanVien.Size = new System.Drawing.Size(255, 55);
			this.btn_NhanVien.TabIndex = 5;
			this.btn_NhanVien.Text = "Quản Lý Nhân Viên";
			this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_NhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_NhanVien.UseVisualStyleBackColor = false;
			this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
			// 
			// DonHangTransition
			// 
			this.DonHangTransition.Interval = 20;
			this.DonHangTransition.Tick += new System.EventHandler(this.SanPhamTransition_Tick);
			// 
			// ptb_SideBar
			// 
			this.ptb_SideBar.BackColor = System.Drawing.Color.Beige;
			this.ptb_SideBar.Image = ((System.Drawing.Image)(resources.GetObject("ptb_SideBar.Image")));
			this.ptb_SideBar.Location = new System.Drawing.Point(0, 3);
			this.ptb_SideBar.Name = "ptb_SideBar";
			this.ptb_SideBar.Size = new System.Drawing.Size(56, 44);
			this.ptb_SideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptb_SideBar.TabIndex = 1;
			this.ptb_SideBar.TabStop = false;
			this.ptb_SideBar.Click += new System.EventHandler(this.ptb_SideBar_Click);
			// 
			// sideBarTransition
			// 
			this.sideBarTransition.Interval = 3;
			this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
			// 
			// ptb_Admin
			// 
			this.ptb_Admin.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Admin.Image")));
			this.ptb_Admin.Location = new System.Drawing.Point(-3, -3);
			this.ptb_Admin.Name = "ptb_Admin";
			this.ptb_Admin.Size = new System.Drawing.Size(258, 130);
			this.ptb_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptb_Admin.TabIndex = 0;
			this.ptb_Admin.TabStop = false;
			// 
			// fPanel_Sidebar
			// 
			this.fPanel_Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.fPanel_Sidebar.Controls.Add(this.pn_PictureBox);
			this.fPanel_Sidebar.Controls.Add(this.btn_TrangChu);
			this.fPanel_Sidebar.Controls.Add(this.btn_QuanLySach);
			this.fPanel_Sidebar.Controls.Add(this.btn_KhachHang);
			this.fPanel_Sidebar.Controls.Add(this.btn_NhanVien);
			this.fPanel_Sidebar.Controls.Add(this.fl_PanelDonHang);
			this.fPanel_Sidebar.Controls.Add(this.fl_Panel_BaoCao);
			this.fPanel_Sidebar.Controls.Add(this.btn_Account);
			this.fPanel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.fPanel_Sidebar.Location = new System.Drawing.Point(0, 36);
			this.fPanel_Sidebar.Name = "fPanel_Sidebar";
			this.fPanel_Sidebar.Size = new System.Drawing.Size(258, 745);
			this.fPanel_Sidebar.TabIndex = 8;
			// 
			// pn_PictureBox
			// 
			this.pn_PictureBox.Controls.Add(this.ptb_Admin);
			this.pn_PictureBox.Location = new System.Drawing.Point(3, 3);
			this.pn_PictureBox.Name = "pn_PictureBox";
			this.pn_PictureBox.Size = new System.Drawing.Size(255, 127);
			this.pn_PictureBox.TabIndex = 8;
			// 
			// fl_PanelDonHang
			// 
			this.fl_PanelDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.fl_PanelDonHang.Controls.Add(this.btn_HoaDon);
			this.fl_PanelDonHang.Controls.Add(this.btn_HoaDonBan);
			this.fl_PanelDonHang.Controls.Add(this.btn_HoaDonNhap);
			this.fl_PanelDonHang.Location = new System.Drawing.Point(3, 383);
			this.fl_PanelDonHang.Name = "fl_PanelDonHang";
			this.fl_PanelDonHang.Size = new System.Drawing.Size(255, 60);
			this.fl_PanelDonHang.TabIndex = 6;
			// 
			// btn_HoaDon
			// 
			this.btn_HoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_HoaDon.FlatAppearance.BorderSize = 0;
			this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
			this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
			this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_HoaDon.Location = new System.Drawing.Point(3, 3);
			this.btn_HoaDon.Name = "btn_HoaDon";
			this.btn_HoaDon.Size = new System.Drawing.Size(246, 52);
			this.btn_HoaDon.TabIndex = 7;
			this.btn_HoaDon.Text = "Quản Lý Đơn Hàng";
			this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_HoaDon.UseVisualStyleBackColor = false;
			this.btn_HoaDon.Click += new System.EventHandler(this.btn_DonHang_Click);
			// 
			// btn_HoaDonBan
			// 
			this.btn_HoaDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_HoaDonBan.FlatAppearance.BorderSize = 0;
			this.btn_HoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_HoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_HoaDonBan.ForeColor = System.Drawing.Color.White;
			this.btn_HoaDonBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_HoaDonBan.Location = new System.Drawing.Point(3, 61);
			this.btn_HoaDonBan.Name = "btn_HoaDonBan";
			this.btn_HoaDonBan.Size = new System.Drawing.Size(264, 56);
			this.btn_HoaDonBan.TabIndex = 7;
			this.btn_HoaDonBan.Text = "      Hóa Đơn Bán Hàng";
			this.btn_HoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_HoaDonBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_HoaDonBan.UseVisualStyleBackColor = false;
			this.btn_HoaDonBan.Click += new System.EventHandler(this.btn_HoaDonBan_Click);
			// 
			// btn_HoaDonNhap
			// 
			this.btn_HoaDonNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_HoaDonNhap.FlatAppearance.BorderSize = 0;
			this.btn_HoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_HoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_HoaDonNhap.ForeColor = System.Drawing.Color.White;
			this.btn_HoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_HoaDonNhap.Location = new System.Drawing.Point(3, 123);
			this.btn_HoaDonNhap.Name = "btn_HoaDonNhap";
			this.btn_HoaDonNhap.Size = new System.Drawing.Size(264, 56);
			this.btn_HoaDonNhap.TabIndex = 7;
			this.btn_HoaDonNhap.Text = "      Hóa Đơn Nhập Hàng";
			this.btn_HoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_HoaDonNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_HoaDonNhap.UseVisualStyleBackColor = false;
			this.btn_HoaDonNhap.Click += new System.EventHandler(this.btn_HoaDonNhap_Click);
			// 
			// fl_Panel_BaoCao
			// 
			this.fl_Panel_BaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.fl_Panel_BaoCao.Controls.Add(this.btn_BaoCao);
			this.fl_Panel_BaoCao.Controls.Add(this.btn_BaoCaoBanHang);
			this.fl_Panel_BaoCao.Controls.Add(this.btn_BaoCaoTonKho);
			this.fl_Panel_BaoCao.Location = new System.Drawing.Point(3, 449);
			this.fl_Panel_BaoCao.Name = "fl_Panel_BaoCao";
			this.fl_Panel_BaoCao.Size = new System.Drawing.Size(251, 63);
			this.fl_Panel_BaoCao.TabIndex = 8;
			// 
			// btn_BaoCao
			// 
			this.btn_BaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_BaoCao.FlatAppearance.BorderSize = 0;
			this.btn_BaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_BaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_BaoCao.ForeColor = System.Drawing.Color.White;
			this.btn_BaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btn_BaoCao.Image")));
			this.btn_BaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_BaoCao.Location = new System.Drawing.Point(3, 3);
			this.btn_BaoCao.Name = "btn_BaoCao";
			this.btn_BaoCao.Size = new System.Drawing.Size(246, 56);
			this.btn_BaoCao.TabIndex = 7;
			this.btn_BaoCao.Text = "Báo Cáo Thống Kê";
			this.btn_BaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_BaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_BaoCao.UseVisualStyleBackColor = false;
			this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click);
			// 
			// btn_BaoCaoBanHang
			// 
			this.btn_BaoCaoBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_BaoCaoBanHang.FlatAppearance.BorderSize = 0;
			this.btn_BaoCaoBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_BaoCaoBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_BaoCaoBanHang.ForeColor = System.Drawing.Color.White;
			this.btn_BaoCaoBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_BaoCaoBanHang.Location = new System.Drawing.Point(3, 65);
			this.btn_BaoCaoBanHang.Name = "btn_BaoCaoBanHang";
			this.btn_BaoCaoBanHang.Size = new System.Drawing.Size(264, 56);
			this.btn_BaoCaoBanHang.TabIndex = 7;
			this.btn_BaoCaoBanHang.Text = "      Báo Cáo Bán Hàng";
			this.btn_BaoCaoBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_BaoCaoBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_BaoCaoBanHang.UseVisualStyleBackColor = false;
			this.btn_BaoCaoBanHang.Click += new System.EventHandler(this.btn_BaoCaoBanHang_Click);
			// 
			// btn_BaoCaoTonKho
			// 
			this.btn_BaoCaoTonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_BaoCaoTonKho.FlatAppearance.BorderSize = 0;
			this.btn_BaoCaoTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_BaoCaoTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_BaoCaoTonKho.ForeColor = System.Drawing.Color.White;
			this.btn_BaoCaoTonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_BaoCaoTonKho.Location = new System.Drawing.Point(3, 127);
			this.btn_BaoCaoTonKho.Name = "btn_BaoCaoTonKho";
			this.btn_BaoCaoTonKho.Size = new System.Drawing.Size(264, 56);
			this.btn_BaoCaoTonKho.TabIndex = 7;
			this.btn_BaoCaoTonKho.Text = "      Báo Cáo Tồn Kho";
			this.btn_BaoCaoTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_BaoCaoTonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_BaoCaoTonKho.UseVisualStyleBackColor = false;
			this.btn_BaoCaoTonKho.Click += new System.EventHandler(this.btn_BaoCaoTonKho_Click);
			// 
			// btn_Account
			// 
			this.btn_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.btn_Account.FlatAppearance.BorderSize = 0;
			this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Account.ForeColor = System.Drawing.Color.White;
			this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
			this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Account.Location = new System.Drawing.Point(3, 518);
			this.btn_Account.Name = "btn_Account";
			this.btn_Account.Size = new System.Drawing.Size(249, 56);
			this.btn_Account.TabIndex = 4;
			this.btn_Account.Text = "Tài khoản hệ thống";
			this.btn_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_Account.UseVisualStyleBackColor = false;
			this.btn_Account.Click += new System.EventHandler(this.btn_AccountSystem_Click);
			// 
			// panel_Body
			// 
			this.panel_Body.Controls.Add(this.guna2PictureBox1);
			this.panel_Body.Controls.Add(this.guna2GradientPanel1);
			this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Body.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
			this.panel_Body.Location = new System.Drawing.Point(258, 36);
			this.panel_Body.Name = "panel_Body";
			this.panel_Body.Size = new System.Drawing.Size(1133, 745);
			this.panel_Body.TabIndex = 0;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BorderRadius = 20;
			this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(0, 50);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(1133, 695);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 2;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2GradientPanel1
			// 
			this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.guna2GradientPanel1.Controls.Add(this.lb_Admin);
			this.guna2GradientPanel1.Controls.Add(this.ptb_SideBar);
			this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.Info;
			this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SteelBlue;
			this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new System.Drawing.Size(1133, 50);
			this.guna2GradientPanel1.TabIndex = 1;
			// 
			// lb_Admin
			// 
			this.lb_Admin.AutoSize = true;
			this.lb_Admin.BackColor = System.Drawing.Color.Transparent;
			this.lb_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Admin.ForeColor = System.Drawing.Color.White;
			this.lb_Admin.Location = new System.Drawing.Point(817, 14);
			this.lb_Admin.Name = "lb_Admin";
			this.lb_Admin.Size = new System.Drawing.Size(80, 25);
			this.lb_Admin.TabIndex = 0;
			this.lb_Admin.Text = "Admin:";
			// 
			// mn_HeThong
			// 
			this.mn_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.mn_HeThong.Name = "mn_HeThong";
			this.mn_HeThong.Size = new System.Drawing.Size(108, 32);
			this.mn_HeThong.Text = "Hệ thống";
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
			this.logOutToolStripMenuItem.Text = "Đăng xuất";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
			this.exitToolStripMenuItem.Text = "Thoát";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// cateToolStripMenuItem
			// 
			this.cateToolStripMenuItem.Name = "cateToolStripMenuItem";
			this.cateToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
			this.cateToolStripMenuItem.Text = "Danh mục";
			// 
			// statisticsToolStripMenuItem
			// 
			this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
			this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
			this.statisticsToolStripMenuItem.Text = "Thống kê";
			// 
			// infomationToolStripMenuItem
			// 
			this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
			this.infomationToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
			this.infomationToolStripMenuItem.Text = "Thông tin";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_HeThong,
            this.cateToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.infomationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1391, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// baoCaoTransition
			// 
			this.baoCaoTransition.Interval = 20;
			this.baoCaoTransition.Tick += new System.EventHandler(this.baoCaoTransition_Tick);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1391, 781);
			this.Controls.Add(this.panel_Body);
			this.Controls.Add(this.fPanel_Sidebar);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BookStore Management";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ptb_SideBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptb_Admin)).EndInit();
			this.fPanel_Sidebar.ResumeLayout(false);
			this.pn_PictureBox.ResumeLayout(false);
			this.fl_PanelDonHang.ResumeLayout(false);
			this.fl_Panel_BaoCao.ResumeLayout(false);
			this.panel_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
		private Button btn_QuanLySach;
		private Button btn_TrangChu;
		private Timer DonHangTransition;
		private Button btn_NhanVien;
		private Button btn_KhachHang;
		private PictureBox ptb_SideBar;
		private Timer sideBarTransition;
		private PictureBox ptb_Admin;
		private FlowLayoutPanel fPanel_Sidebar;
		private FlowLayoutPanel fl_PanelDonHang;
		private Button btn_BaoCao;
		private Button btn_HoaDon;
		private Button btn_HoaDonBan;
		private Button btn_HoaDonNhap;
		private FlowLayoutPanel fl_Panel_BaoCao;
		private Button btn_BaoCaoBanHang;
		private Button btn_BaoCaoTonKho;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private Panel pn_PictureBox;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel_Body;
        private ToolStripMenuItem mn_HeThong;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cateToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem infomationToolStripMenuItem;
        private MenuStrip menuStrip1;
		private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
		private Label lb_Admin;
		private Timer baoCaoTransition;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Button btn_Account;
	}
}