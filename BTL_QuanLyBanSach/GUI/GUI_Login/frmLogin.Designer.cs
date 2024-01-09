namespace BTL_QuanLyBanSach.GUI.GUI_Login
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txb_Username = new Guna.UI2.WinForms.Guna2TextBox();
			this.txb_Password = new Guna.UI2.WinForms.Guna2TextBox();
			this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
			this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(573, 552);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(158, 289);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(158, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(111, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 32);
			this.label5.TabIndex = 4;
			this.label5.Text = "     ";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(146, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 42);
			this.label4.TabIndex = 0;
			this.label4.Text = "Sign In";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(111, 289);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 29);
			this.label6.TabIndex = 4;
			this.label6.Text = "     ";
			// 
			// txb_Username
			// 
			this.txb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txb_Username.AutoRoundedCorners = true;
			this.txb_Username.BorderColor = System.Drawing.Color.RosyBrown;
			this.txb_Username.BorderRadius = 21;
			this.txb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txb_Username.DefaultText = "DoXuanTrang";
			this.txb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txb_Username.FillColor = System.Drawing.SystemColors.Info;
			this.txb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txb_Username.ForeColor = System.Drawing.Color.Black;
			this.txb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txb_Username.Location = new System.Drawing.Point(53, 216);
			this.txb_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txb_Username.Name = "txb_Username";
			this.txb_Username.PasswordChar = '\0';
			this.txb_Username.PlaceholderText = "";
			this.txb_Username.SelectedText = "";
			this.txb_Username.Size = new System.Drawing.Size(305, 45);
			this.txb_Username.TabIndex = 0;
			// 
			// txb_Password
			// 
			this.txb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txb_Password.BorderColor = System.Drawing.Color.RosyBrown;
			this.txb_Password.BorderRadius = 20;
			this.txb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txb_Password.DefaultText = "123";
			this.txb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txb_Password.FillColor = System.Drawing.SystemColors.Info;
			this.txb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txb_Password.ForeColor = System.Drawing.Color.Black;
			this.txb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txb_Password.Location = new System.Drawing.Point(50, 333);
			this.txb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txb_Password.Name = "txb_Password";
			this.txb_Password.PasswordChar = '●';
			this.txb_Password.PlaceholderForeColor = System.Drawing.Color.White;
			this.txb_Password.PlaceholderText = "";
			this.txb_Password.SelectedText = "";
			this.txb_Password.Size = new System.Drawing.Size(308, 47);
			this.txb_Password.TabIndex = 1;
			this.txb_Password.UseSystemPasswordChar = true;
			// 
			// btn_Login
			// 
			this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Login.BorderRadius = 25;
			this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.ForeColor = System.Drawing.Color.White;
			this.btn_Login.Location = new System.Drawing.Point(53, 420);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(121, 48);
			this.btn_Login.TabIndex = 6;
			this.btn_Login.Text = "Sign in";
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Cancel.BorderRadius = 25;
			this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btn_Cancel.ForeColor = System.Drawing.Color.White;
			this.btn_Cancel.Location = new System.Drawing.Point(237, 420);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(121, 48);
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(372, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(37, 35);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 7;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_1);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.guna2PictureBox1);
			this.panel1.Controls.Add(this.btn_Cancel);
			this.panel1.Controls.Add(this.btn_Login);
			this.panel1.Controls.Add(this.txb_Password);
			this.panel1.Controls.Add(this.txb_Username);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(118)))));
			this.panel1.Location = new System.Drawing.Point(568, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(412, 552);
			this.panel1.TabIndex = 2;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 25;
			this.guna2Elipse1.TargetControl = this;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(980, 552);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập Hệ Thống";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label6;
		public Guna.UI2.WinForms.Guna2TextBox txb_Username;
		public Guna.UI2.WinForms.Guna2TextBox txb_Password;
		public Guna.UI2.WinForms.Guna2Button btn_Login;
		public Guna.UI2.WinForms.Guna2Button btn_Cancel;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		public System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
	}
}