using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienQLQuanTS.BLL
{
    public class SanPham_BLL
    {
        private static SanPham_BLL _Instance;

        public static SanPham_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SanPham_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public SanPham_BLL()
        {

        }
        public List<SANPHAM> GetListSPByDanhMuc(int maDM)
        {
            SE_10Entities db = new SE_10Entities();
            List<SANPHAM> list = new List<SANPHAM>();
            list = db.SANPHAMs.Where(p => p.MaDM == maDM).ToList();
            return list;
        }
    }
}
