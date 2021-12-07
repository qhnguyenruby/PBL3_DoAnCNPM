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
    public partial class TrangChu : Form
    {
        private TAIKHOAN _LoginAccount;

        public TAIKHOAN LoginAccount { get => _LoginAccount; set => _LoginAccount = value; }

        public TrangChu(TAIKHOAN account)
        {
            InitializeComponent();

            this.LoginAccount = account;
            SetView();
        }

        
        private void SetView()
        {
            adminToolStripMenuItem.Enabled = LoginAccount.LoaiTK == 1;
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tttk = new ThongTinTaiKhoan(LoginAccount);
            tttk.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanHang bh = new BanHang();
            bh.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
