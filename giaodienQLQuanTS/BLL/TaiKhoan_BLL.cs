
using giaodienQLQuanTS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodienQLQuanTS.BLL
{
    public class TaiKhoan_BLL
    {
        private static TaiKhoan_BLL _Instance;

        public static TaiKhoan_BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new TaiKhoan_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        public TaiKhoan_BLL()
        {

        }

        

        public bool Login(string userName, string passWord)
        {
            using (SE_10Entities db = new SE_10Entities())
            {
                var result = db.SP_Login(userName, passWord);
                return result.Count() > 0;
            }
        }

        public TAIKHOAN GetAccountByUserName(string TenDN)
        {
            using (SE_10Entities db = new SE_10Entities())
            {
                TAIKHOAN tk = db.TAIKHOANs.Where(t => t.TenDN == TenDN).FirstOrDefault();
                return tk;
            }
        }
    }
}
