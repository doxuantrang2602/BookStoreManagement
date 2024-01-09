using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using BTL_QuanLyBanSach.GUI.GUI_Admin;
using BTL.Main.Main_Form;
using BaiTapLon;
using System.Security.Cryptography;

namespace BTL_QuanLyBanSach.GUI.GUI_Login
{
	public partial class frmLogin : Form
	{
        DataProcesserTrang dtbase = new DataProcesserTrang();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmLogin()
        {          
            InitializeComponent();
        }
		public static string HashPassword(string password)
		{
			using (MD5 md5 = MD5.Create())
			{
				byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
				byte[] hashBytes = md5.ComputeHash(inputBytes);
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					sb.Append(hashBytes[i].ToString("X2"));
				}
				return sb.ToString();
			}
		}
		public Tuple<bool,string,int> login(string username, string password)
        {
			string hashedPassword = HashPassword(password);
			Dictionary<string, object> parameters = new Dictionary<string, object>()
		    {
			    { "@username", username },
			    { "@password", hashedPassword }
		    };

			System.Data.DataTable dt = dtbase.SearchData("EXEC CheckLogin @username, @password", parameters);
			if (dt.Rows.Count > 0)
			{
                string roleID = dt.Rows[0]["RoleID"].ToString();
                int status = Convert.ToInt32(dt.Rows[0]["Status"]);
                return System.Tuple.Create(true, roleID,status);
			}
			return System.Tuple.Create(false,string.Empty,-1);
		}

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txb_Username.Text;
            string password = txb_Password.Text;
            if (userName.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
                return;
            }
            var loginResult = login(userName, password);
            if (loginResult.Item1)
            {
                if(loginResult.Item3 == 0)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa!");
                    return;
                }
                else if(loginResult.Item3 == 1)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    this.Hide();
                    switch (loginResult.Item2)
                    {
                        case "1":
                            FrmMain frmMain = new FrmMain();
                            frmMain.ShowDialog();
                            break;
                        case "2":
                            frmThuKho frm = new frmThuKho();
							frm.ShowDialog();
                            break;
                        case "3":
                            Main frmBanHang = new Main();
                            frmBanHang.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Không xác định được vai trò của người dùng.");
                            break;
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Trạng thái tài khoản không hợp lệ!");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new System.Drawing.Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new System.Drawing.Size(diff));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
