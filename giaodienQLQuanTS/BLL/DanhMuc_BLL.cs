using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienQLQuanTS.BLL
{
    public class DanhMuc_BLL
    {
        private static DanhMuc_BLL _Instance;

        public static DanhMuc_BLL Instance 
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DanhMuc_BLL();
                return _Instance;
            }
            private set => _Instance = value; 
        }

        public DanhMuc_BLL() { }

        public List<DANHMUC> GetListDanhMuc()
        {
            SE_10Entities db = new SE_10Entities();
            List<DANHMUC> list = new List<DANHMUC>();
            list = db.DANHMUCs.ToList();
            return list;
        }
    }
}
