using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienQLQuanTS.BLL
{
    public class Ban_BLL
    {
        private static Ban_BLL _Instance;

        public static Ban_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Ban_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public Ban_BLL()
        {

        }

        public static int TableWidth = 80;
        public static int TableHeight = 80;
        public List<BAN> GetTableList()
        {
            using (SE_10Entities db = new SE_10Entities())
            {
                return db.BANs.ToList();
            }
        }
    }
}
