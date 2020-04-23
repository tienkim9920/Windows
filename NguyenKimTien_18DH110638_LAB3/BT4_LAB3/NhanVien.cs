using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_LAB3
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

        public NhanVien()
        {
            hoTen = "Nguyen Kim Tien";
            mucLuong = 500000;
            soNgayVang = 1;
        }

        public double luong()
        {
            return mucLuong - soNgayVang * 100000;
        }
    }
}
