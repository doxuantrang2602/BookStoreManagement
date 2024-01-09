using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyBanSach.Classes;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
    public partial class frmEmployeeDetails : Form
    {
        DataProcesserTrang dtBase = new DataProcesserTrang();
        public event Action OnDataChanged;
        private bool imageChanged = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Status currentStatus { get; set; }

        public frmEmployeeDetails()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txb_MaNV.Text = string.Empty;
            txb_HoTenNV.Text = string.Empty;
            txb_DiaChi.Text = string.Empty;
            txb_Email.Text = string.Empty;
            txb_Sdt.Text = string.Empty;
            dtpt_NgaySinh.Value = DateTime.Now;
            dtpk_NgayVaoLam.Value = DateTime.Now;
            cb_ChucVu2.SelectedIndex = -1;
            ptb_AnhDaiDien.Image = null;
            SetReadOnly(false);
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            string sqlRole = "select RoleID, RoleName from Role";
            DataTable dataRole = new DataTable();
            dataRole = dtBase.ReadData(sqlRole);
            cb_ChucVu2.DataSource = dataRole;
            cb_ChucVu2.DisplayMember = "RoleName";
            cb_ChucVu2.ValueMember = "RoleID";
            cb_ChucVu2.SelectedIndex = -1;
        }
        public void SetReadOnly(bool readOnly)
        {
            txb_MaNV.ReadOnly = readOnly;
            txb_HoTenNV.ReadOnly = readOnly;
            txb_DiaChi.ReadOnly = readOnly;
            txb_Email.ReadOnly = readOnly;
            txb_Sdt.ReadOnly = readOnly;
            dtpt_NgaySinh.Enabled = !readOnly;
            dtpk_NgayVaoLam.Enabled = !readOnly;
            cb_ChucVu2.Enabled = !readOnly;
        }

        public void EmployeeDetails(DataGridViewRow currentRow)
        {
            txb_MaNV.Text = currentRow.Cells[0].Value.ToString();
            txb_HoTenNV.Text = currentRow.Cells[1].Value.ToString();
            dtpt_NgaySinh.Value = Convert.ToDateTime(currentRow.Cells[2].Value);
            txb_DiaChi.Text = currentRow.Cells[3].Value.ToString();
            txb_Email.Text = currentRow.Cells[4].Value.ToString();
            txb_Sdt.Text = currentRow.Cells[5].Value.ToString();
            dtpk_NgayVaoLam.Value = Convert.ToDateTime(currentRow.Cells[6].Value);
            cb_ChucVu2.Text = currentRow.Cells[7].Value.ToString(); 
            byte[] imageBytes = (byte[])currentRow.Cells[8].Value;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                ptb_AnhDaiDien.Image = System.Drawing.Image.FromStream(ms);
            }
        }
        private void btn_Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|All Files|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptb_AnhDaiDien.Image = System.Drawing.Image.FromFile(openFile.FileName);
                imageChanged = true;
            }
        }
        private byte[] ChuyenAnhThanhChuoiArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void themNV(bool updateImage)
        {
            byte[] imageBytes = null;
            if (updateImage)
            {
                imageBytes = ChuyenAnhThanhChuoiArray(ptb_AnhDaiDien.Image);
            }
            string sqlInsert = updateImage? "INSERT INTO Employee " +
                "VALUES (@MaNV, @HoTenNV, @NgaySinh, @DiaChi, @Email, @Sdt, @NgayVaoLam, @ChucVuId, @Picture)" :
                "INSERT INTO Employee " +
                "VALUES (@MaNV, @HoTenNV, @NgaySinh, @DiaChi, @Email, @Sdt, @NgayVaoLam, @ChucVuId, NULL)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@MaNV", txb_MaNV.Text},
                {"@HoTenNV", txb_HoTenNV.Text},
                {"@NgaySinh", dtpt_NgaySinh.Value},
                {"@DiaChi", txb_DiaChi.Text},
                {"@Email", txb_Email.Text},
                {"@Sdt",  txb_Sdt.Text},
                {"@NgayVaoLam", dtpk_NgayVaoLam.Value},
                {"@ChucVuId", cb_ChucVu2.SelectedValue.ToString()}
            };
            if (updateImage)
            {
                parameters.Add("@Picture",imageBytes);
            }
            else
            {
                parameters.Add("@Picture", DBNull.Value);
            }
            System.Data.DataTable dtNV = dtBase.ReadData("Select * from Employee where EmployeeID= '" + txb_MaNV.Text + "' ");
            if (dtNV.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có. Bạn hãy nhập mã khác !");
                txb_MaNV.Focus();
                return;
            }
            if (dtBase.ChangeData(sqlInsert, parameters))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                OnDataChanged?.Invoke();
                this.Close();               
                return;
            }
            else
            {
                MessageBox.Show("Không thể thêm nhân viên. Vui lòng kiểm tra lại thông tin nhập.");
            }
            
        }
        public void capNhatNV(bool updateImage)
        {
            byte[] imageBytes = null;

            if (updateImage)
            {
                imageBytes = ChuyenAnhThanhChuoiArray(ptb_AnhDaiDien.Image);
            }
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Chỉnh sửa",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlUpdate =updateImage? 
                    "Update Employee set FullName=@FullName, " +
                    "DateOfBirth=@DateOfBirth, Address=@Address, Email=@Email, PhoneNumber=@PhoneNumber, " +
                    "StartWorkDate=@StartWorkDate, RoleID=@RoleID, Picture=@Picture " +
                    "where EmployeeID=@EmployeeID " :
                    "Update Employee set FullName=@FullName, " +
                    "DateOfBirth=@DateOfBirth, Address=@Address, Email=@Email, PhoneNumber=@PhoneNumber, " +
                    "StartWorkDate=@StartWorkDate, RoleID=@RoleID " +
                    "where EmployeeID=@EmployeeID ";
                Dictionary<string, object> prmt = new Dictionary<string, object>()
                {
                    {"@EmployeeID", txb_MaNV.Text},
                    {"@FullName", txb_HoTenNV.Text},
                    {"@DateOfBirth", dtpt_NgaySinh.Value},
                    {"@Address", txb_DiaChi.Text},
                    {"@Email", txb_Email.Text},
                    {"@PhoneNumber", txb_Sdt.Text},
                    {"@StartWorkDate", dtpk_NgayVaoLam.Value},
                    {"@RoleID",cb_ChucVu2.SelectedValue},
                };
                if (updateImage)
                {
                    prmt.Add("@Picture", imageBytes);
                }
                if (dtBase.ChangeData(sqlUpdate, prmt))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    OnDataChanged?.Invoke();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    return;
                }
            }
            
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            switch (currentStatus)
            {
                case Status.Add:
                    if (imageChanged)
                    {
                        themNV(true);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm dữ liệu.");
                    }
                    break;
                case Status.Update:
                    capNhatNV(imageChanged);
                    imageChanged = false;
                    break;
                case Status.View:
                    this.Close();
                    break;
                default:
                    throw new InvalidOperationException("Chế độ không được hỗ trợ");
            }
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
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
    }
}
