using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_LAB1
{
    class NhanVien
    {
        public string hoTen;
        public double mucLuong;
        public int soNgayVang;

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }

        public double Luong()
        {
            if ((this.mucLuong - this.soNgayVang * 100000) > 0)
            {
                return this.mucLuong - this.soNgayVang * 100000;
            }
            return 0;
        }

        public string OutPut()
        {
            return "\nLuong Nhan Vien La: " + Luong();
        }
    }
}
