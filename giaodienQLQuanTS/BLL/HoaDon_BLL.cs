
using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienQLQuanTS.BLL
{
    public class HoaDon_BLL
    {
        private static HoaDon_BLL _Instance;

        public static HoaDon_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new HoaDon_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public HoaDon_BLL()
        {

        }

        

        //public void ShowBill(int maBan)
        //{
        //    HoaDon_DAO.Instance.ShowBill(maBan);
        //}
        public HOADON GetUnCheckOutBill(int maBan)
        {
            SE_10Entities db = new SE_10Entities();
            
            HOADON hd = db.HOADONs.Where(h => h.MaBan == maBan).Where(h => h.TrangThai == 0).FirstOrDefault();
            return hd;
            
        }

        public void InsertBill(HOADON hd)
        {
            SE_10Entities db = new SE_10Entities();

            db.HOADONs.Add(hd);
            db.SaveChanges();
        }

        public void CheckOut(int SoHD)
        {
            SE_10Entities db = new SE_10Entities();

            HOADON hd = db.HOADONs.Where(p => p.SoHD == SoHD).FirstOrDefault();
            hd.TrangThai = 1;
            BAN ban = db.BANs.Where(p => p.MaBan == hd.MaBan).FirstOrDefault();
            ban.TrangThai = "Trống";

            db.SaveChanges();
        }

        public int GetMaxBill()
        {
            SE_10Entities db = new SE_10Entities();
            List<int> listSoHD = new List<int>();

            foreach(HOADON i in db.HOADONs.ToList())
            {
                listSoHD.Add(i.SoHD);
            }
            int SoHDMax = listSoHD.Max();
            HOADON hd = db.HOADONs.Where(p => p.SoHD == SoHDMax).FirstOrDefault();
            return hd.SoHD;
        }
    }
}
