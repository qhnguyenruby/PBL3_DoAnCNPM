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
    public partial class ChonMon : Form
    {
        public delegate void Mydel();
        private Mydel _D;
        private static TAIKHOAN _TaiKhoan;
        private BAN _Ban;
        public ChonMon(BAN Ban)
        {
            InitializeComponent();
            this.Ban = Ban;
            SetView();
            SetCBBCategory();
        }

        public BAN Ban { get => _Ban; set => _Ban = value; }
        public static TAIKHOAN TaiKhoan { get => _TaiKhoan; set => _TaiKhoan = value; }
        public Mydel D { get => _D; set => _D = value; }

        private void SetView()
        {
            if(Ban != null)
            {
                if(Ban.TrangThai == "Có người")
                {
                    but_BookTable.Hide();
                    but_CancelBookTable.Hide();
                    ShowBill(Ban);
                }
                else
                {
                    if (Ban.TrangThai == "Đã đặt")
                        but_BookTable.Hide();
                    else
                        but_CancelBookTable.Hide();
                }
                txbTable.Text = Ban.TenBan;

            }
            else
            {
                lbTable.Hide();
                txbTable.Hide();
                cbSwitchTable.Hide();
                but_SwitchTable.Hide();
                but_BookTable.Hide();
                but_CancelBookTable.Hide();
            }
        }

        public void ShowBill(BAN ban)
        {
            SE_10Entities db = new SE_10Entities();
            lvBill.Items.Clear();
            double totalPrice = 0;
            List<DTO.Menu> listMenu = Menu_BLL.Instance.GetMenuByTable(ban);
            
            foreach (DTO.Menu i in listMenu)
            {
                ListViewItem listViewItem = new ListViewItem(i.TenSP);
                listViewItem.SubItems.Add(i.SoLuong.ToString());
                listViewItem.SubItems.Add(i.DonGia.ToString());
                listViewItem.SubItems.Add(i.ThanhTien.ToString());
                totalPrice += i.ThanhTien;
                lvBill.Items.Add(listViewItem);

            }
            txtTotalPrice.Text = totalPrice.ToString();
        }
        public void SetCBBCategory()
        {
            SE_10Entities db = new SE_10Entities();
            
            foreach (DANHMUC i in db.DANHMUCs)
            {
                cbCategory.Items.Add(new CBBItem { Value = i.MaDM, Text = i.TenDM });
            }
            cbCategory.SelectedIndex = 0;
        }
        public void SetCBBProduct(int maDM)
        {
            cbProduct.Items.Clear();
            SE_10Entities db = new SE_10Entities();
            
            var listSP = SanPham_BLL.Instance.GetListSPByDanhMuc(maDM);
            foreach (SANPHAM i in listSP)
            {
                cbProduct.Items.Add(new CBBItem { Value = i.MaSP, Text = i.TenSP });
            }
            cbProduct.SelectedIndex = 0;
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDM = 0;
            
            if (cbCategory.SelectedItem == null)
                return;
            
            maDM = ((CBBItem)cbCategory.SelectedItem).Value;
            SetCBBProduct(maDM);
        }

        private void but_ThemMon_Click(object sender, EventArgs e)
        {
            SE_10Entities db = new SE_10Entities();

            
            SANPHAM sanpham = db.SANPHAMs.Where(p => p.MaSP == ((CBBItem)cbProduct.SelectedItem).Value).FirstOrDefault();
            if(Ban == null)
            {
                HOADON newHD = new HOADON()
                {
                    IdTK = TaiKhoan.IdTK,
                    MaBan = null,
                    TrangThai = 0,
                    NgayTao = DateTime.Now,
                    TongTien = 0
                };
                HoaDon_BLL.Instance.InsertBill(newHD);
                CHITIETHOADON cthd = new CHITIETHOADON()
                {
                    SoHD = newHD.SoHD,
                    MaSP = sanpham.MaSP,
                    SoLuong = Convert.ToInt32(nmudQuantity.Value),
                    DonGia = sanpham.GiaTien,
                    GiamGia = Convert.ToInt32(nmudDiscount.Value),
                    ThanhTien = Convert.ToInt32(nmudQuantity.Value) * sanpham.GiaTien * (100 - Convert.ToInt32(nmudDiscount.Value)) / 100
                };
                ChiTietHoaDon_BLL.Instance.InsertBillInfo(cthd);
            }
            else
            {
                BAN ban = db.BANs.Where(p => p.MaBan == Ban.MaBan).FirstOrDefault();
                HOADON HD = HoaDon_BLL.Instance.GetUnCheckOutBill(Ban.MaBan);
                if (HD == null)
                {
                    ban.TrangThai = "Có người";
                    db.SaveChanges();
                    HOADON newHD = new HOADON()
                    {
                        IdTK = TaiKhoan.IdTK,
                        MaBan = Ban.MaBan,
                        TrangThai = 0,
                        NgayTao = DateTime.Now,
                        TongTien = 0
                    };
                    HoaDon_BLL.Instance.InsertBill(newHD);
                    CHITIETHOADON cthd = new CHITIETHOADON()
                    {
                        SoHD = newHD.SoHD,
                        MaSP = sanpham.MaSP,
                        SoLuong = Convert.ToInt32(nmudQuantity.Value),
                        DonGia = sanpham.GiaTien,
                        GiamGia = Convert.ToInt32(nmudDiscount.Value),
                        ThanhTien = Convert.ToInt32(nmudQuantity.Value) * sanpham.GiaTien * (100 - Convert.ToInt32(nmudDiscount.Value)) / 100
                    };
                    ChiTietHoaDon_BLL.Instance.InsertBillInfo(cthd);
                }
                else
                {
                    CHITIETHOADON CTHD = db.CHITIETHOADONs.Where(p => p.MaSP == sanpham.MaSP).Where(p => p.SoHD == HD.SoHD).FirstOrDefault();
                    if (CTHD == null)
                    {
                        CHITIETHOADON cthd = new CHITIETHOADON()
                        {
                            SoHD = HD.SoHD,
                            MaSP = sanpham.MaSP,
                            SoLuong = Convert.ToInt32(nmudQuantity.Value),
                            DonGia = sanpham.GiaTien,
                            GiamGia = Convert.ToInt32(nmudDiscount.Value),
                            ThanhTien = Convert.ToInt32(nmudQuantity.Value) * sanpham.GiaTien * (100 - Convert.ToInt32(nmudDiscount.Value)) / 100
                        };
                        ChiTietHoaDon_BLL.Instance.InsertBillInfo(cthd);
                    }
                    else
                    {
                        int newcount = Convert.ToInt32(nmudQuantity.Value) + CTHD.SoLuong;
                        if (newcount > 0)
                        {
                            CTHD.SoLuong += Convert.ToInt32(nmudQuantity.Value);
                            CTHD.ThanhTien = Convert.ToDouble(CTHD.SoLuong * CTHD.DonGia * (100 - CTHD.GiamGia) / 100);
                            db.SaveChanges();
                        }
                        else
                        {
                            db.CHITIETHOADONs.Remove(CTHD);
                            db.SaveChanges();
                        }
                    }

                }
                
                if (D != null)
                {
                    D();
                }
            }
            ShowBill(Ban);
        }

        private void but_CheckOut_Click(object sender, EventArgs e)
        {
            SE_10Entities db = new SE_10Entities();
            HOADON HD = HoaDon_BLL.Instance.GetUnCheckOutBill(Ban.MaBan);

            if(HD != null)
            {
                if(MessageBox.Show(string.Format("Bạn có thực sự muốn thanh toán hóa đơn bàn {0}\nTổng tiền = {1}",Ban.TenBan, Convert.ToDouble(txtTotalPrice.Text))
                    , "Thông báo"
                    , MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    HoaDon_BLL.Instance.CheckOut(HD.SoHD);                    

                    ShowBill(Ban);

                    if (D != null)
                    {
                        D();
                    }
                }    
            }
        }

        private void but_BookTable_Click(object sender, EventArgs e)
        {
            SE_10Entities db = new SE_10Entities();
            BAN ban = db.BANs.Where(p => p.MaBan == Ban.MaBan).FirstOrDefault();

            ban.TrangThai = "Đã đặt";
            db.SaveChanges();
            if (D != null)
            {
                D();
            }
            
        }

        private void but_CancelBookTable_Click(object sender, EventArgs e)
        {
            SE_10Entities db = new SE_10Entities();
            BAN ban = db.BANs.Where(p => p.MaBan == Ban.MaBan).FirstOrDefault();

            ban.TrangThai = "Trống";
            db.SaveChanges();
            if (D != null)
            {
                D();
            }
        }
    }
}
