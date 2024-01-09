namespace BTL.Main.Control
{
    partial class U_Search
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
			this.cbPublisher = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataViewBook = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPublishYear = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtStockAmount = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtStoreAmount = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViewBook)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(474, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "TÌM KIẾM THÔNG TIN";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1133, 42);
			this.panel2.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.cbPublisher);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbCategory);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1133, 61);
			this.panel1.TabIndex = 16;
			// 
			// btnSearch
			// 
			this.btnSearch.Animated = true;
			this.btnSearch.AutoRoundedCorners = true;
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.BorderRadius = 17;
			this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Image = global::BTL_QuanLyBanSach.Properties.Resources.search;
			this.btnSearch.IndicateFocus = true;
			this.btnSearch.Location = new System.Drawing.Point(774, 7);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(64, 36);
			this.btnSearch.TabIndex = 38;
			this.btnSearch.UseTransparentBackground = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cbPublisher
			// 
			this.cbPublisher.AutoRoundedCorners = true;
			this.cbPublisher.BackColor = System.Drawing.Color.Transparent;
			this.cbPublisher.BorderRadius = 12;
			this.cbPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPublisher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPublisher.ForeColor = System.Drawing.Color.Black;
			this.cbPublisher.ItemHeight = 21;
			this.cbPublisher.Location = new System.Drawing.Point(531, 15);
			this.cbPublisher.Name = "cbPublisher";
			this.cbPublisher.Size = new System.Drawing.Size(198, 27);
			this.cbPublisher.TabIndex = 37;
			this.cbPublisher.Click += new System.EventHandler(this.cbPublisher_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(406, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 28);
			this.label2.TabIndex = 36;
			this.label2.Text = "Nhà xuất bản :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbCategory
			// 
			this.cbCategory.AutoRoundedCorners = true;
			this.cbCategory.BackColor = System.Drawing.Color.Transparent;
			this.cbCategory.BorderRadius = 12;
			this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCategory.ForeColor = System.Drawing.Color.Black;
			this.cbCategory.ItemHeight = 21;
			this.cbCategory.Location = new System.Drawing.Point(155, 15);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(198, 27);
			this.cbCategory.TabIndex = 35;
			this.cbCategory.Click += new System.EventHandler(this.cbCategory_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(66, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 28);
			this.label4.TabIndex = 34;
			this.label4.Text = "Thể loại :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataViewBook
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataViewBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataViewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViewBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataViewBook.ColumnHeadersHeight = 30;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataViewBook.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataViewBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataViewBook.Location = new System.Drawing.Point(25, 126);
			this.dataViewBook.Name = "dataViewBook";
			this.dataViewBook.ReadOnly = true;
			this.dataViewBook.RowHeadersVisible = false;
			this.dataViewBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataViewBook.RowTemplate.ReadOnly = true;
			this.dataViewBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataViewBook.Size = new System.Drawing.Size(671, 432);
			this.dataViewBook.TabIndex = 34;
			this.dataViewBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataViewBook.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataViewBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataViewBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataViewBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataViewBook.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataViewBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataViewBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataViewBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataViewBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataViewBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataViewBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataViewBook.ThemeStyle.HeaderStyle.Height = 30;
			this.dataViewBook.ThemeStyle.ReadOnly = true;
			this.dataViewBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataViewBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataViewBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataViewBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataViewBook.ThemeStyle.RowsStyle.Height = 22;
			this.dataViewBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataViewBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataViewBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewBook_CellClick);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtDescription);
			this.panel3.Controls.Add(this.txtPublishYear);
			this.panel3.Controls.Add(this.txtStockAmount);
			this.panel3.Controls.Add(this.txtStoreAmount);
			this.panel3.Controls.Add(this.txtPrice);
			this.panel3.Location = new System.Drawing.Point(720, 126);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(394, 432);
			this.panel3.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(18, 251);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(83, 28);
			this.label8.TabIndex = 47;
			this.label8.Text = "Mô tả :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(18, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 28);
			this.label7.TabIndex = 46;
			this.label7.Text = "Năm xuất bản :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 28);
			this.label6.TabIndex = 45;
			this.label6.Text = "Số lượng kho :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 28);
			this.label5.TabIndex = 44;
			this.label5.Text = "Số lượng :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 28);
			this.label3.TabIndex = 39;
			this.label3.Text = "Giá bán :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.AutoScroll = true;
			this.txtDescription.BorderRadius = 20;
			this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDescription.DefaultText = "";
			this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDescription.Enabled = false;
			this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDescription.Location = new System.Drawing.Point(147, 251);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.PasswordChar = '\0';
			this.txtDescription.PlaceholderText = "";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.SelectedText = "";
			this.txtDescription.Size = new System.Drawing.Size(232, 146);
			this.txtDescription.TabIndex = 43;
			// 
			// txtPublishYear
			// 
			this.txtPublishYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPublishYear.BorderRadius = 10;
			this.txtPublishYear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txtPublishYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPublishYear.DefaultText = "";
			this.txtPublishYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPublishYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPublishYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPublishYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPublishYear.Enabled = false;
			this.txtPublishYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPublishYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPublishYear.ForeColor = System.Drawing.Color.Black;
			this.txtPublishYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPublishYear.Location = new System.Drawing.Point(147, 193);
			this.txtPublishYear.Margin = new System.Windows.Forms.Padding(4);
			this.txtPublishYear.Name = "txtPublishYear";
			this.txtPublishYear.PasswordChar = '\0';
			this.txtPublishYear.PlaceholderText = "";
			this.txtPublishYear.ReadOnly = true;
			this.txtPublishYear.SelectedText = "";
			this.txtPublishYear.Size = new System.Drawing.Size(232, 27);
			this.txtPublishYear.TabIndex = 41;
			// 
			// txtStockAmount
			// 
			this.txtStockAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStockAmount.BorderRadius = 10;
			this.txtStockAmount.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txtStockAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtStockAmount.DefaultText = "";
			this.txtStockAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtStockAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtStockAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtStockAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtStockAmount.Enabled = false;
			this.txtStockAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtStockAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStockAmount.ForeColor = System.Drawing.Color.Black;
			this.txtStockAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtStockAmount.Location = new System.Drawing.Point(147, 130);
			this.txtStockAmount.Margin = new System.Windows.Forms.Padding(4);
			this.txtStockAmount.Name = "txtStockAmount";
			this.txtStockAmount.PasswordChar = '\0';
			this.txtStockAmount.PlaceholderText = "";
			this.txtStockAmount.ReadOnly = true;
			this.txtStockAmount.SelectedText = "";
			this.txtStockAmount.Size = new System.Drawing.Size(232, 27);
			this.txtStockAmount.TabIndex = 40;
			// 
			// txtStoreAmount
			// 
			this.txtStoreAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStoreAmount.BorderRadius = 10;
			this.txtStoreAmount.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txtStoreAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtStoreAmount.DefaultText = "";
			this.txtStoreAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtStoreAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtStoreAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtStoreAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtStoreAmount.Enabled = false;
			this.txtStoreAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtStoreAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStoreAmount.ForeColor = System.Drawing.Color.Black;
			this.txtStoreAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtStoreAmount.Location = new System.Drawing.Point(147, 74);
			this.txtStoreAmount.Margin = new System.Windows.Forms.Padding(4);
			this.txtStoreAmount.Name = "txtStoreAmount";
			this.txtStoreAmount.PasswordChar = '\0';
			this.txtStoreAmount.PlaceholderText = "";
			this.txtStoreAmount.ReadOnly = true;
			this.txtStoreAmount.SelectedText = "";
			this.txtStoreAmount.Size = new System.Drawing.Size(232, 27);
			this.txtStoreAmount.TabIndex = 39;
			// 
			// txtPrice
			// 
			this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrice.BorderRadius = 10;
			this.txtPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPrice.DefaultText = "";
			this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrice.Enabled = false;
			this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.ForeColor = System.Drawing.Color.Black;
			this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrice.Location = new System.Drawing.Point(147, 20);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.PasswordChar = '\0';
			this.txtPrice.PlaceholderText = "";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.SelectedText = "";
			this.txtPrice.Size = new System.Drawing.Size(232, 27);
			this.txtPrice.TabIndex = 38;
			// 
			// U_Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.dataViewBook);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "U_Search";
			this.Size = new System.Drawing.Size(1133, 574);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViewBook)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2ComboBox cbPublisher;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Button btnSearch;
		private Guna.UI2.WinForms.Guna2DataGridView dataViewBook;
		private System.Windows.Forms.Panel panel3;
		private Guna.UI2.WinForms.Guna2TextBox txtPublishYear;
		private Guna.UI2.WinForms.Guna2TextBox txtStockAmount;
		private Guna.UI2.WinForms.Guna2TextBox txtStoreAmount;
		private Guna.UI2.WinForms.Guna2TextBox txtPrice;
		private Guna.UI2.WinForms.Guna2TextBox txtDescription;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
	}
}
