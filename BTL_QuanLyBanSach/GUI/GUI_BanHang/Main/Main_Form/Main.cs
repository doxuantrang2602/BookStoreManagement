using BTL.DataProcess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Main.Main_Form
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void AddpnControl(UserControl c)
        {
            c.Dock = DockStyle.Fill;
            pnControl.Controls.Clear();
            pnControl.Controls.Add(c);
        }

        private void btnThuNgan_Click(object sender, EventArgs e)
        {
            Control.U_ThuNgan u_ThuNgan = new Control.U_ThuNgan();
            AddpnControl(u_ThuNgan);
        }

        private void btnHisBill_Click(object sender, EventArgs e)
        {
            Control.U_LSHD u_LSHD = new Control.U_LSHD();
            AddpnControl(u_LSHD);
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            Control.U_LSNH u_LSNH = new Control.U_LSNH();
            AddpnControl(u_LSNH);
        }

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Control.U_Search u_Search = new Control.U_Search();
			AddpnControl(u_Search);
		}

		private void pnControl_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
