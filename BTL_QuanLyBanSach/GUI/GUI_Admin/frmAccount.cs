using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    public partial class frmAccount : Form
    {
        DataProcesserTrang dtBase = new DataProcesserTrang();
        Dictionary<int, string> dicStatus = new Dictionary<int, string>()
        {
            {0,"Đã khóa" },
            {1,"Hoạt động" }

        };
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmAccount()
        {
            InitializeComponent();
            loadTable();           
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            dtgv_Account.ReadOnly = true;
            foreach (DataGridViewColumn column in dtgv_Account.Columns)
            {
                column.ReadOnly = true;
            }
            cb_TrangThaiTim.DataSource = new BindingSource(dicStatus, null);
            cb_TrangThaiTim.DisplayMember = "Value";
            cb_TrangThaiTim.ValueMember = "Key";
            cb_TrangThaiTim.SelectedIndex = -1;

            cb_TrangThaiNhap.DataSource = new BindingSource(dicStatus, null);
            cb_TrangThaiNhap.DisplayMember = "Value";
            cb_TrangThaiNhap.ValueMember = "Key";
            cb_TrangThaiNhap.SelectedIndex = -1;

            string sqlEmployee = "Select EmployeeID from Employee";
            DataTable dtEmployee = dtBase.ReadData(sqlEmployee);
            cb_MaNV.DataSource = dtEmployee;
            cb_MaNV.DisplayMember = "EmployeeID";
            cb_MaNV.ValueMember = "EmployeeID";
            cb_MaNV.SelectedIndex = -1;
        }

        public void loadTable()
        {
            string sqlSelect = "Select AccountID, Account.EmployeeID, Employee.FullName, Role.RoleName," +
                "Account.Username,Account.Password," +
                "case Account.Status " +
                    "when 0 then N'Đã khóa' " +
                    "when 1 then N'Hoạt động' " +
                    "else N'Không xác định' " +
                "end as Status " +
                "from Account " +
                "inner join Employee on Account.EmployeeID=Employee.EmployeeID " +
                "inner join Role on Role.RoleID=Employee.RoleID";
            DataTable dataAcc = dtBase.ReadData(sqlSelect);
            dtgv_Account.DataSource = dataAcc;
        }

        private void guna2GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void guna2GradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaNV = cb_MaNV.SelectedValue as string;
            if (!string.IsNullOrEmpty(selectedMaNV))
            {
                string query = "Select FullName,RoleName " +
                    "from Employee " +
                    "inner join Role on Role.RoleID = Employee.RoleID " +
                    "where EmployeeID=@EmployeeID";
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@EmployeeID",selectedMaNV }
                };
                DataTable data = dtBase.SearchData(query, parameters);
                if (data.Rows.Count > 0)
                {
                    string tenNV = data.Rows[0]["FullName"].ToString();
                    string chucVu = data.Rows[0]["RoleName"].ToString();
                    txb_TenNV.Text = tenNV;
                    txb_ChucVu.Text = chucVu;
                }
            }
        }
        public static string HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }


        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            DataTable dataAcc = dtBase.ReadData("select * from Account where AccountID=N'"+txb_MaTK.Text+"'");
            if(dataAcc.Rows.Count > 0)
            {
                MessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng chọn mã khác!");
                return;
            }
            DataTable dataUser = dtBase.ReadData("select * from Account where Username=N'" + txb_Username.Text + "'");
            if (dataUser.Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác!");
                return;
            }
            string hashedPassword = HashPassword(txb_Password.Text);
            string sqlInsert = "Insert into Account values(@AccountID, @EmployeeID, @Username, @Password, @Status)";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@AccountID",txb_MaTK.Text},
                {"@EmployeeID",cb_MaNV.SelectedValue},
                {"@Username",txb_Username.Text},
                {"@Password",hashedPassword},
                {"@Status",cb_TrangThaiNhap.SelectedValue}
            };
            if(dtBase.ChangeData(sqlInsert, parameters))
            {
                MessageBox.Show("Tạo tài khoản mới thành công !");
                loadTable();
                return;
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại !");
            }
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            if (dtgv_Account.CurrentRow == null)
            {
                MessageBox.Show("Bạn muốn xóa tài khoản nào ?");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này không ?",
                                   "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string maTKCanXoa = dtgv_Account.CurrentRow.Cells[0].Value.ToString();
                    string sqlDel = "Delete from Account where AccountID = @AccountID";
                    Dictionary<string, object> prmt = new Dictionary<string, object>()
                    {
                        {"@AccountID", maTKCanXoa}
                    };
                    if (dtBase.ChangeData(sqlDel, prmt))
                    {
                        MessageBox.Show("Xóa thành công !");
                        loadTable();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }

            }
        }
        private void dtgv_Account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txb_MaTK.Text = dtgv_Account.CurrentRow.Cells[0].Value.ToString();
                cb_MaNV.Text = dtgv_Account.CurrentRow.Cells[1].Value.ToString();
                txb_Username.Text = dtgv_Account.CurrentRow.Cells[4].Value.ToString();
                txb_Password.Text = dtgv_Account.CurrentRow.Cells[5].Value.ToString();
                cb_TrangThaiNhap.Text = dtgv_Account.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void brn_SuaTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
				string hashedPassword = HashPassword(txb_Password.Text);
				string sqlUpdate = "Update Account set EmployeeID=@EmployeeID, Username=@Username," +
                    "Password=@Password, Status=@Status " +
                    "where AccountID=@AccountID";
                Dictionary<string, object> prmt = new Dictionary<string, object>()
                {
                    {"@AccountID", txb_MaTK.Text},
                    {"@EmployeeID", cb_MaNV.SelectedValue},
                    {"@Username", txb_Username.Text},
                    {"@Password", hashedPassword},
                    {"@Status", cb_TrangThaiNhap.SelectedValue.ToString()},
                };
                if (dtBase.ChangeData(sqlUpdate, prmt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    loadTable();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    return;
                }
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            foreach (var m in this.pn_Nhap.Controls)
            {
                if (m is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)m;
                    textBox.Text = "";
                }

                else if (m is Guna2ComboBox)
                {
                    Guna2ComboBox cb = (Guna2ComboBox)m;
                    cb.SelectedIndex = -1;
                }
            }
            foreach (var n in this.pn_Tim.Controls)
            {
                if (n is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)n;
                    textBox.Text = "";
                }

                else if (n is Guna2ComboBox)
                {
                    Guna2ComboBox cb = (Guna2ComboBox)n;
                    cb.SelectedIndex = -1;
                }
            }
        }

        private void cb_TrangThaiTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TrangThaiTim.SelectedIndex != -1)
            {
                try
                {
                    int selectedStatus = ((KeyValuePair<int, string>)cb_TrangThaiTim.SelectedItem).Key;
                    string sqlFilter = "Select AccountID, Account.EmployeeID, Employee.FullName, Role.RoleName," +
                        "Account.Username,Account.Password," +
                        "case Account.Status " +
                            "when 0 then N'Đã khóa' " +
                            "when 1 then N'Hoạt động' " +
                            "else N'Không xác định' " +
                        "end as Status " +
                        "from Account " +
                        "inner join Employee on Account.EmployeeID=Employee.EmployeeID " +
                        "inner join Role on Role.RoleID=Employee.RoleID " +
                        "where Status=@Status";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        {"@Status", selectedStatus}
                    };
                    DataTable filterData = dtBase.SearchData(sqlFilter, parameters);
                    dtgv_Account.DataSource = filterData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lọc: " + ex.Message);
                }
            }
            else
            {
                loadTable();
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string keyword = txb_TuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }
            string query = "Select AccountID, Account.EmployeeID, Employee.FullName, Role.RoleName," +
                        "Account.Username,Account.Password," +
                        "case Account.Status " +
                            "when 0 then N'Đã khóa' " +
                            "when 1 then N'Hoạt động' " +
                            "else N'Không xác định' " +
                        "end as Status " +
                        "from Account " +
                        "inner join Employee on Account.EmployeeID=Employee.EmployeeID " +
                        "inner join Role on Role.RoleID=Employee.RoleID " +
                        "where AccountID like @Key or Account.EmployeeID like @Key or FullName like @Key or " +
                        "RoleName like @Key or Username like @Key or Password like @Key";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Key", "%"+keyword+"%" }
            };
            System.Data.DataTable data = dtBase.SearchData(query, parameters);
            if (data.Rows.Count > 0)
            {
                dtgv_Account.DataSource = data;
                MessageBox.Show("Found " + keyword + " !");
            }
            else
            {
                MessageBox.Show("Not Found " + keyword + " !");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            loadTable();
            cb_TrangThaiTim.SelectedIndex = -1;
            txb_TuKhoa.Text = "";         
        }
    }
}
