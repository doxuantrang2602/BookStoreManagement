namespace BTL.Main.Main_Form
{
    partial class Main
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnThuNgan = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnHisBill = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnGraphics = new Guna.UI2.WinForms.Guna2GradientButton();
			this.pnControl = new System.Windows.Forms.Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.btnThuNgan);
			this.panel1.Controls.Add(this.btnHisBill);
			this.panel1.Controls.Add(this.btnGraphics);
			this.panel1.Location = new System.Drawing.Point(0, 215);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(177, 315);
			this.panel1.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.BorderRadius = 10;
			this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(3, 228);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(162, 45);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnThuNgan
			// 
			this.btnThuNgan.BorderRadius = 10;
			this.btnThuNgan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThuNgan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThuNgan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThuNgan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThuNgan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThuNgan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnThuNgan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThuNgan.ForeColor = System.Drawing.Color.White;
			this.btnThuNgan.Location = new System.Drawing.Point(3, 24);
			this.btnThuNgan.Name = "btnThuNgan";
			this.btnThuNgan.Size = new System.Drawing.Size(162, 45);
			this.btnThuNgan.TabIndex = 0;
			this.btnThuNgan.Text = "Thu ngân";
			this.btnThuNgan.Click += new System.EventHandler(this.btnThuNgan_Click);
			// 
			// btnHisBill
			// 
			this.btnHisBill.BorderRadius = 10;
			this.btnHisBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHisBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHisBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHisBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHisBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHisBill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnHisBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHisBill.ForeColor = System.Drawing.Color.White;
			this.btnHisBill.Location = new System.Drawing.Point(3, 154);
			this.btnHisBill.Name = "btnHisBill";
			this.btnHisBill.Size = new System.Drawing.Size(162, 45);
			this.btnHisBill.TabIndex = 2;
			this.btnHisBill.Text = "Lịch sử hóa đơn";
			this.btnHisBill.Click += new System.EventHandler(this.btnHisBill_Click);
			// 
			// btnGraphics
			// 
			this.btnGraphics.BorderRadius = 10;
			this.btnGraphics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnGraphics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnGraphics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnGraphics.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnGraphics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnGraphics.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnGraphics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGraphics.ForeColor = System.Drawing.Color.White;
			this.btnGraphics.Location = new System.Drawing.Point(3, 89);
			this.btnGraphics.Name = "btnGraphics";
			this.btnGraphics.Size = new System.Drawing.Size(162, 45);
			this.btnGraphics.TabIndex = 1;
			this.btnGraphics.Text = "Doanh thu";
			this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
			// 
			// pnControl
			// 
			this.pnControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnControl.Location = new System.Drawing.Point(183, 0);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(985, 530);
			this.pnControl.TabIndex = 2;
			this.pnControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnControl_Paint);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::BTL_QuanLyBanSach.Properties.Resources.avatar;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(177, 215);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 530);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.pnControl);
			this.Controls.Add(this.panel1);
			this.Name = "Main";
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnControl;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2GradientButton btnThuNgan;
		private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
		private Guna.UI2.WinForms.Guna2GradientButton btnHisBill;
		private Guna.UI2.WinForms.Guna2GradientButton btnGraphics;
	}
}