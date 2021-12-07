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
    public partial class ThongTinTaiKhoan : Form
    {
        private TAIKHOAN _LoginAccount;
        public ThongTinTaiKhoan(TAIKHOAN account)
        {
            InitializeComponent();

            this.LoginAccount = account;
        }

        public TAIKHOAN LoginAccount 
        { 
            get => _LoginAccount;
            set
            {
                _LoginAccount = value;
                txbIDTK.Text = LoginAccount.IdTK;
                txbTenDN.Text = LoginAccount.TenDN;
                txbTenHT.Text = LoginAccount.TenHT;
            }
        }
    }
}
