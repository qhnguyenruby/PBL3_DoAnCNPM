using giaodienQLQuanTS.BLL;
using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodienQLQuanTS
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            if (TaiKhoan_BLL.Instance.Login(txbTenDN.Text, txbMatKhau.Text))
            {
                TAIKHOAN loginAccount = TaiKhoan_BLL.Instance.GetAccountByUserName(txbTenDN.Text);
                TrangChu tc = new TrangChu(loginAccount);
                ChonMon.TaiKhoan = loginAccount;
                this.Hide();
                tc.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
