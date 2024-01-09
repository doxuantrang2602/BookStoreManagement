using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_QuanLyBanSach.GUI.GUI_Login;

namespace BTL_QuanLyBanSach.GUI.GUI_Admin
{
	public partial class FrmMain : Form
	{
		public static frmLogin frmLogin = new frmLogin();
		private bool isSidebarHidden = false;
		private int sidebarWidth = 261;
		private const int animationSpeed = 10;
		public FrmMain()
		{
			InitializeComponent();
			this.lb_Admin.Text = "Admin: " + frmLogin.txb_Username.Text;

		}

		private void customerManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}
		private Form currentFormChild;
		private void openChildForm(Form childForm)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			currentFormChild = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panel_Body.Controls.Add(childForm);
			panel_Body.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		private void btn_TrangChu_Click(object sender, EventArgs e)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
				currentFormChild = null;
			}
			foreach (Control c in panel_Body.Controls)
			{
				c.Visible = true;
			}
		}

		private void btn_QuanLySach_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel_Body.Controls)
            {
                c.Visible = false;
            }

            openChildForm(new FrmBooks());
        }
        
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel_Body.Controls)
            {
                c.Visible = false;
            }

            openChildForm(new frmEmployee());
        }

		private void btn_KhachHang_Click(object sender, EventArgs e)
		{
            foreach (Control c in panel_Body.Controls)
            {
                c.Visible = false;
            }
            openChildForm(new frmCustomer());
		}
        private void btn_AccountSystem_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel_Body.Controls)
            {
                c.Visible = false;
            }
            openChildForm(new frmAccount());
        }
		private void btn_DonHang_Click(object sender, EventArgs e)
		{
            DonHangTransition.Start();
        }
		private void btn_HoaDonBan_Click(object sender, EventArgs e)
		{
			foreach (Control c in panel_Body.Controls)
			{
				c.Visible = false;
			}
			openChildForm(new frmBill());
		}
		private void btn_HoaDonNhap_Click(object sender, EventArgs e)
		{
			foreach (Control c in panel_Body.Controls)
			{
				c.Visible = false;
			}

			openChildForm(new frmBillImport());
		}

		private void btn_BaoCao_Click(object sender, EventArgs e)
		{
			baoCaoTransition.Start();
		}
		
		private void btn_BaoCaoBanHang_Click(object sender, EventArgs e)
		{
			foreach (Control c in panel_Body.Controls)
			{
				c.Visible = false;
			}

			openChildForm(new frmSaleReport());
		}

		private void btn_BaoCaoTonKho_Click(object sender, EventArgs e)
		{
			foreach (Control c in panel_Body.Controls)
			{
				c.Visible = false;
			}

			openChildForm(new frmStockReport());
		}
		bool menuExpand = false;
		private void SanPhamTransition_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
                fl_PanelDonHang.Height += 10;
				if (fl_PanelDonHang.Height >= 189)
				{
					DonHangTransition.Stop();
					menuExpand = true;
				}
			}
			else
			{
                fl_PanelDonHang.Height -= 10;
				if (fl_PanelDonHang.Height <= 55)
				{
					DonHangTransition.Stop();
					menuExpand = false;
				}
			}
		}
		private void baoCaoTransition_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				fl_Panel_BaoCao.Height += 10;
				if (fl_Panel_BaoCao.Height >= 189)
				{
					baoCaoTransition.Stop();
					menuExpand = true;
				}
			}
			else
			{
				fl_Panel_BaoCao.Height -= 10;
				if (fl_Panel_BaoCao.Height <= 63)
				{
					baoCaoTransition.Stop();
					menuExpand = false;
				}
			}
		}	
		private void ptb_SideBar_Click(object sender, EventArgs e)
		{
			sideBarTransition.Start();
		}
		bool sidebarExpand = true;
		private void sideBarTransition_Tick(object sender, EventArgs e)
		{
			if (sidebarExpand)
			{
				fPanel_Sidebar.Width -= 5;
				if (fPanel_Sidebar.Width <= 47)
				{
					sidebarExpand = false;
					sideBarTransition.Stop();
					UpdatePictureBoxSize();
					//btn_TrangChu.Width = fPanel_Sidebar.Width;
					//fPanel_SanPham.Width = fPanel_Sidebar.Width;
					//btn_DonHang.Width = fPanel_Sidebar.Width;
					//btn_KhachHang.Width = fPanel_Sidebar.Width;
					//btn_NhanVien.Width = fPanel_Sidebar.Width;
				}
			}
			else
			{
				fPanel_Sidebar.Width += 5;
				if (fPanel_Sidebar.Width >= 258)
				{
					sidebarExpand = true;
					sideBarTransition.Stop();
					UpdatePictureBoxSize();
					//btn_TrangChu.Width = fPanel_Sidebar.Width;
					//fPanel_SanPham.Width = fPanel_Sidebar.Width;
					//btn_DonHang.Width = fPanel_Sidebar.Width;
					//btn_KhachHang.Width = fPanel_Sidebar.Width;
					//btn_NhanVien.Width = fPanel_Sidebar.Width;
				}
			}
		}
		private void UpdatePictureBoxSize()
		{
			if (sidebarExpand)
			{
				pn_PictureBox.Width = 255;
				pn_PictureBox.Height = 127;
			}
			else
			{
				pn_PictureBox.Width = 0; 
				pn_PictureBox.Height = 0;
			}
		}

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?",
                                    "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }
	}
}
