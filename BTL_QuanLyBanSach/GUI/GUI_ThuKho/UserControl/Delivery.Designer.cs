namespace BaiTapLon
{
    partial class Delivery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxBookID = new System.Windows.Forms.ComboBox();
            this.txtDeliveryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveryAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDeliveryDetailList = new System.Windows.Forms.DataGridView();
            this.gunabtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.gunabtnFinish = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetailList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 197);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gunabtnFinish);
            this.panel5.Controls.Add(this.gunabtnCancel);
            this.panel5.Controls.Add(this.gunabtnAdd);
            this.panel5.Controls.Add(this.cbxBookID);
            this.panel5.Controls.Add(this.txtDeliveryID);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtDeliveryAmount);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1003, 121);
            this.panel5.TabIndex = 53;
            // 
            // cbxBookID
            // 
            this.cbxBookID.FormattingEnabled = true;
            this.cbxBookID.Location = new System.Drawing.Point(449, 23);
            this.cbxBookID.Name = "cbxBookID";
            this.cbxBookID.Size = new System.Drawing.Size(203, 28);
            this.cbxBookID.TabIndex = 60;
            this.cbxBookID.Click += new System.EventHandler(this.cbxBookID_Click);
            // 
            // txtDeliveryID
            // 
            this.txtDeliveryID.Location = new System.Drawing.Point(151, 25);
            this.txtDeliveryID.Name = "txtDeliveryID";
            this.txtDeliveryID.Size = new System.Drawing.Size(187, 26);
            this.txtDeliveryID.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Mã phiếu chuyển:";
            // 
            // txtDeliveryAmount
            // 
            this.txtDeliveryAmount.Location = new System.Drawing.Point(809, 25);
            this.txtDeliveryAmount.Name = "txtDeliveryAmount";
            this.txtDeliveryAmount.Size = new System.Drawing.Size(140, 26);
            this.txtDeliveryAmount.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tên sách:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxEmployee);
            this.panel4.Controls.Add(this.dtpDeliveryDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1003, 76);
            this.panel4.TabIndex = 51;
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(663, 22);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(238, 28);
            this.cbxEmployee.TabIndex = 53;
            this.cbxEmployee.Click += new System.EventHandler(this.cbxEmployee_Click);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(203, 24);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(240, 26);
            this.dtpDeliveryDate.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ngày chuyển:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Nhân viên:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(16, 449);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(987, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 449);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(16, 633);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 13);
            this.panel3.TabIndex = 3;
            // 
            // dgvDeliveryDetailList
            // 
            this.dgvDeliveryDetailList.AllowUserToAddRows = false;
            this.dgvDeliveryDetailList.AllowUserToResizeColumns = false;
            this.dgvDeliveryDetailList.AllowUserToResizeRows = false;
            this.dgvDeliveryDetailList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDeliveryDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeliveryDetailList.Location = new System.Drawing.Point(16, 197);
            this.dgvDeliveryDetailList.Name = "dgvDeliveryDetailList";
            this.dgvDeliveryDetailList.RowHeadersWidth = 62;
            this.dgvDeliveryDetailList.RowTemplate.Height = 28;
            this.dgvDeliveryDetailList.Size = new System.Drawing.Size(971, 436);
            this.dgvDeliveryDetailList.TabIndex = 4;
            this.dgvDeliveryDetailList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryDetailList_CellDoubleClick);
            // 
            // gunabtnAdd
            // 
            this.gunabtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunabtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunabtnAdd.ForeColor = System.Drawing.Color.White;
            this.gunabtnAdd.Location = new System.Drawing.Point(577, 73);
            this.gunabtnAdd.Name = "gunabtnAdd";
            this.gunabtnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunabtnAdd.Size = new System.Drawing.Size(112, 42);
            this.gunabtnAdd.TabIndex = 61;
            this.gunabtnAdd.Text = "Thêm";
            this.gunabtnAdd.Click += new System.EventHandler(this.gunabtnAdd_Click);
            // 
            // gunabtnCancel
            // 
            this.gunabtnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunabtnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunabtnCancel.ForeColor = System.Drawing.Color.White;
            this.gunabtnCancel.Location = new System.Drawing.Point(721, 73);
            this.gunabtnCancel.Name = "gunabtnCancel";
            this.gunabtnCancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunabtnCancel.Size = new System.Drawing.Size(112, 42);
            this.gunabtnCancel.TabIndex = 62;
            this.gunabtnCancel.Text = "Hủy";
            this.gunabtnCancel.Click += new System.EventHandler(this.gunabtnCancel_Click);
            // 
            // gunabtnFinish
            // 
            this.gunabtnFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnFinish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunabtnFinish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunabtnFinish.ForeColor = System.Drawing.Color.White;
            this.gunabtnFinish.Location = new System.Drawing.Point(865, 73);
            this.gunabtnFinish.Name = "gunabtnFinish";
            this.gunabtnFinish.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunabtnFinish.Size = new System.Drawing.Size(122, 42);
            this.gunabtnFinish.TabIndex = 63;
            this.gunabtnFinish.Text = "Xong";
            this.gunabtnFinish.Click += new System.EventHandler(this.gunabtnFinish_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDeliveryDetailList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Delivery";
            this.Size = new System.Drawing.Size(1003, 646);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetailList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDeliveryDetailList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDeliveryAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeliveryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.ComboBox cbxBookID;
        private Guna.UI2.WinForms.Guna2Button gunabtnAdd;
        private Guna.UI2.WinForms.Guna2Button gunabtnCancel;
        private Guna.UI2.WinForms.Guna2Button gunabtnFinish;
    }
}
