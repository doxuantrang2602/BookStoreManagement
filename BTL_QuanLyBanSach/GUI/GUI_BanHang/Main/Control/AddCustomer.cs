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

namespace BTL.Main.Control
{
    public partial class AddCustomer : Form
    {
		DataProcesserNghien dataPro = new DataProcesserNghien();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dataPro.DataRead("Select CustomerID from Customer where CustomerID = '"+txtCustomerID.Text+"'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đã có mã khách hàng !!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCustomerID.Focus();
                return;
            }
            if(DataPro.Checked.Check(txtCustomerID.Text))
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng !!");
                return;
            }
            if (DataPro.Checked.Check(txtFullName.Text))
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng !!");
                return;
            }
            if (DataPro.Checked.Check(txtPhoneNumber.Text))
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng !!");
                return;
            }
            dataPro.ChangeData("Insert into Customer (CustomerID,FullName,Email,PhoneNumber) values " +
                "('"+txtCustomerID.Text+"'," +
                "'"+txtFullName.Text+"'," +
                "'"+txtGmail.Text+"'," +
                "'"+txtPhoneNumber.Text+"')");
            MessageBox.Show("Thêm thành công !!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Bạn chắc chắn muốn hủy chứ ??",
                "Hủy",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
