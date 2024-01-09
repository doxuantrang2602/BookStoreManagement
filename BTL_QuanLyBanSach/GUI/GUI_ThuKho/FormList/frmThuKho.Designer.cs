using System.Windows.Forms.DataVisualization.Charting;
namespace BaiTapLon
{
    partial class frmThuKho
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtTitle = new System.Windows.Forms.Label();
			this.titletxt = new System.Windows.Forms.Label();
			this.slideTimer = new System.Windows.Forms.Timer(this.components);
			this.pnControl = new System.Windows.Forms.Panel();
			this.addBillImportUC = new BaiTapLon.AddBillImport();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btnAddDelivery = new Guna.UI2.WinForms.Guna2Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnAddBillImport = new Guna.UI2.WinForms.Guna2Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnListInvoice = new Guna.UI2.WinForms.Guna2Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnListBook = new Guna.UI2.WinForms.Guna2Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.slidebtn = new System.Windows.Forms.PictureBox();
			this.slideMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.panel4.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.slidebtn)).BeginInit();
			this.slideMenu.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.panel4.Controls.Add(this.txtTitle);
			this.panel4.Controls.Add(this.titletxt);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel4.Location = new System.Drawing.Point(179, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(669, 41);
			this.panel4.TabIndex = 1;
			// 
			// txtTitle
			// 
			this.txtTitle.AutoSize = true;
			this.txtTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtTitle.Location = new System.Drawing.Point(19, 12);
			this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(0, 17);
			this.txtTitle.TabIndex = 3;
			// 
			// titletxt
			// 
			this.titletxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titletxt.AutoSize = true;
			this.titletxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.titletxt.Location = new System.Drawing.Point(27, 15);
			this.titletxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.titletxt.Name = "titletxt";
			this.titletxt.Size = new System.Drawing.Size(0, 17);
			this.titletxt.TabIndex = 2;
			this.titletxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// slideTimer
			// 
			this.slideTimer.Interval = 10;
			this.slideTimer.Tick += new System.EventHandler(this.slideMenu_Tick);
			// 
			// pnControl
			// 
			this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnControl.Location = new System.Drawing.Point(179, 41);
			this.pnControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnControl.Name = "pnControl";
			this.pnControl.Size = new System.Drawing.Size(669, 420);
			this.pnControl.TabIndex = 2;
			// 
			// addBillImportUC
			// 
			this.addBillImportUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addBillImportUC.Location = new System.Drawing.Point(0, 0);
			this.addBillImportUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.addBillImportUC.Name = "addBillImportUC";
			this.addBillImportUC.Size = new System.Drawing.Size(1003, 646);
			this.addBillImportUC.TabIndex = 2;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.btnAddDelivery);
			this.panel7.Location = new System.Drawing.Point(2, 228);
			this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(179, 44);
			this.panel7.TabIndex = 3;
			// 
			// btnAddDelivery
			// 
			this.btnAddDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.btnAddDelivery.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAddDelivery.ForeColor = System.Drawing.Color.White;
			this.btnAddDelivery.Location = new System.Drawing.Point(-13, -6);
			this.btnAddDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddDelivery.Name = "btnAddDelivery";
			this.btnAddDelivery.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnAddDelivery.Size = new System.Drawing.Size(201, 58);
			this.btnAddDelivery.TabIndex = 10;
			this.btnAddDelivery.Text = "              Chuyển hàng";
			this.btnAddDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnAddDelivery.Click += new System.EventHandler(this.btnAddDelivery_Click);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.btnAddBillImport);
			this.panel6.Location = new System.Drawing.Point(2, 180);
			this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(179, 44);
			this.panel6.TabIndex = 3;
			this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
			// 
			// btnAddBillImport
			// 
			this.btnAddBillImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddBillImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddBillImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddBillImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddBillImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.btnAddBillImport.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAddBillImport.ForeColor = System.Drawing.Color.White;
			this.btnAddBillImport.Location = new System.Drawing.Point(-13, -6);
			this.btnAddBillImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddBillImport.Name = "btnAddBillImport";
			this.btnAddBillImport.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnAddBillImport.Size = new System.Drawing.Size(201, 58);
			this.btnAddBillImport.TabIndex = 9;
			this.btnAddBillImport.Text = "              Nhập kho";
			this.btnAddBillImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnAddBillImport.Click += new System.EventHandler(this.btnAddBillImport_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnListInvoice);
			this.panel3.Location = new System.Drawing.Point(2, 132);
			this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(179, 44);
			this.panel3.TabIndex = 2;
			// 
			// btnListInvoice
			// 
			this.btnListInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnListInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnListInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnListInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnListInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.btnListInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnListInvoice.ForeColor = System.Drawing.Color.White;
			this.btnListInvoice.Location = new System.Drawing.Point(-13, -6);
			this.btnListInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnListInvoice.Name = "btnListInvoice";
			this.btnListInvoice.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnListInvoice.Size = new System.Drawing.Size(201, 58);
			this.btnListInvoice.TabIndex = 8;
			this.btnListInvoice.Text = "              Danh sách phiếu nhập";
			this.btnListInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnListInvoice.Click += new System.EventHandler(this.btnListInvoice_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnListBook);
			this.panel2.Location = new System.Drawing.Point(2, 84);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(179, 44);
			this.panel2.TabIndex = 1;
			// 
			// btnListBook
			// 
			this.btnListBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnListBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnListBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnListBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnListBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.btnListBook.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnListBook.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnListBook.ForeColor = System.Drawing.Color.White;
			this.btnListBook.Location = new System.Drawing.Point(-13, -8);
			this.btnListBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnListBook.Name = "btnListBook";
			this.btnListBook.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnListBook.Size = new System.Drawing.Size(201, 58);
			this.btnListBook.TabIndex = 7;
			this.btnListBook.Text = "Danh sách hàng";
			this.btnListBook.Click += new System.EventHandler(this.btnListBook_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.slidebtn);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(178, 76);
			this.panel1.TabIndex = 0;
			// 
			// slidebtn
			// 
			this.slidebtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.slidebtn.Image = global::BTL_QuanLyBanSach.Properties.Resources.left_arrow;
			this.slidebtn.Location = new System.Drawing.Point(2, 5);
			this.slidebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.slidebtn.Name = "slidebtn";
			this.slidebtn.Size = new System.Drawing.Size(34, 32);
			this.slidebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.slidebtn.TabIndex = 0;
			this.slidebtn.TabStop = false;
			this.slidebtn.Click += new System.EventHandler(this.slideBtn_Click);
			// 
			// slideMenu
			// 
			this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.slideMenu.Controls.Add(this.panel1);
			this.slideMenu.Controls.Add(this.panel2);
			this.slideMenu.Controls.Add(this.panel3);
			this.slideMenu.Controls.Add(this.panel6);
			this.slideMenu.Controls.Add(this.panel7);
			this.slideMenu.Controls.Add(this.panel8);
			this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.slideMenu.Location = new System.Drawing.Point(0, 0);
			this.slideMenu.MaximumSize = new System.Drawing.Size(179, 0);
			this.slideMenu.MinimumSize = new System.Drawing.Size(45, 461);
			this.slideMenu.Name = "slideMenu";
			this.slideMenu.Size = new System.Drawing.Size(179, 461);
			this.slideMenu.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.guna2Button1);
			this.panel8.Location = new System.Drawing.Point(2, 276);
			this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(179, 44);
			this.panel8.TabIndex = 4;
			// 
			// guna2Button1
			// 
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(-13, -6);
			this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2Button1.Size = new System.Drawing.Size(201, 58);
			this.guna2Button1.TabIndex = 11;
			this.guna2Button1.Text = "              Danh sách phiếu chuyển";
			this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// frmThuKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 461);
			this.Controls.Add(this.pnControl);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.slideMenu);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmThuKho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý kho hàng";
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.slidebtn)).EndInit();
			this.slideMenu.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Label titletxt;
        private System.Windows.Forms.Panel pnControl;
        
        private System.Windows.Forms.Label txtTitle;
        private AddBillImport addBillImportUC;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox slidebtn;
        private System.Windows.Forms.FlowLayoutPanel slideMenu;
        //private ListBook listBookUC;
        //private Delivery deliveryUC;
        //private BillImportList billImportListUC;
        private System.Windows.Forms.Panel panel8;
        //private DeliveryListDetail deliveryListDetailUC;
        private Guna.UI2.WinForms.Guna2Button btnListBook;
        private Guna.UI2.WinForms.Guna2Button btnListInvoice;
        private Guna.UI2.WinForms.Guna2Button btnAddBillImport;
        private Guna.UI2.WinForms.Guna2Button btnAddDelivery;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

