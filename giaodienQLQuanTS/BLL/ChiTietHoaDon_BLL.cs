
using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodienQLQuanTS.BLL
{
    public class ChiTietHoaDon_BLL
    {
        private static ChiTietHoaDon_BLL _Instance;

        public static ChiTietHoaDon_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ChiTietHoaDon_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public ChiTietHoaDon_BLL()
        {

        }

        
        public List<CHITIETHOADON> GetBillInfo(int soHD)
        {
            using (SE_10Entities db = new SE_10Entities())
            {
                return db.CHITIETHOADONs.Where(p => p.SoHD == soHD).ToList();
            }
        }

        public void InsertBillInfo(CHITIETHOADON cthd)
        {
            SE_10Entities db = new SE_10Entities();

            db.CHITIETHOADONs.Add(cthd);
            db.SaveChanges();
        }
    }
}
