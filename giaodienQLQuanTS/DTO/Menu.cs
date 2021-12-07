using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodienQLQuanTS.DTO
{
    public class Menu
    {
        private string _TenSP;
        private int _SoLuong;
        private double _DonGia;
        private double _ThanhTien;
        public Menu(string TenSP, int SoLuong, double DonGia, double ThanhTien)
        {
            this.TenSP = TenSP;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
        }

        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public double DonGia { get => _DonGia; set => _DonGia = value; }
        public double ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
    }
}
