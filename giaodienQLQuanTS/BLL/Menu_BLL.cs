
using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienQLQuanTS.BLL
{
    public class Menu_BLL
    {
        private static Menu_BLL _Instance;

        public static Menu_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Menu_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public Menu_BLL()
        {

        }
        
        public List<Menu> GetMenuByTable(BAN ban = null)
        {
            using (SE_10Entities db = new SE_10Entities())
            {
                List<Menu> listMenu = new List<Menu>();
                if(ban != null)
                {
                    foreach (var i in db.CHITIETHOADONs.Where(p => p.HOADON.MaBan == ban.MaBan).Where(p => p.HOADON.TrangThai == 0).ToList())
                    {
                        listMenu.Add(new Menu(i.SANPHAM.TenSP, i.SoLuong, i.DonGia, i.ThanhTien));
                    }
                }
                else
                {
                    int SoHD = HoaDon_BLL.Instance.GetMaxBill();
                    foreach (var i in db.CHITIETHOADONs.Where(p => p.HOADON.SoHD == SoHD).ToList())
                    {
                        listMenu.Add(new Menu(i.SANPHAM.TenSP, i.SoLuong, i.DonGia, i.ThanhTien));
                    }
                }
                return listMenu;
            }

        }
    }
}
