
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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();

            LoadTable();
        }

        public void LoadTable()
        {
            flpBan.Controls.Clear();
            foreach (BAN i in Ban_BLL.Instance.GetTableList())
            {
                Button btn = new Button() { Width = Ban_BLL.TableWidth, Height = Ban_BLL.TableHeight };
                btn.Text = i.TenBan + Environment.NewLine + i.TrangThai;
                btn.Tag = i;
                btn.Click += Btn_Click;
            
                switch (i.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    case "Có người":
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flpBan.Controls.Add(btn);
                
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ChonMon cm = new ChonMon((sender as Button).Tag as BAN);
            cm.D += new ChonMon.Mydel(LoadTable);
            cm.ShowDialog();
        }

        //private void BanHang_Click(object sender, EventArgs e)
        //{
        //    int maBan = (((sender as ToolStripMenuItem).Tag) as BAN).MaBan;
        //    using (SE_10Entities db = new SE_10Entities())
        //    {
        //        BAN ban = db.BANs.Where(b => b.MaBan == maBan).FirstOrDefault();

        //        ban.TrangThai = "Đã đặt";
        //        db.SaveChanges();
        //        //LoadTable();
        //    }
        //}       

        private void but_MuaVe_Click(object sender, EventArgs e)
        {
            ChonMon cm = new ChonMon(null);
            
            cm.ShowDialog();
        }

        





        //private void but_DatBan_Click(object sender, EventArgs e)
        //{

        //    using (SE_10Entities db = new SE_10Entities())
        //    {
        //        BAN ban = db.BANs.Where(b => b.MaBan == MaBan).FirstOrDefault();

        //        ban.TrangThai = "Đã đặt";
        //        db.SaveChanges();
        //    }
        //}


    }
}
