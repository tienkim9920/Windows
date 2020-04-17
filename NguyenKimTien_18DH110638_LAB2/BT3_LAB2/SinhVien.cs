using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB2
{
    class SinhVien
    {
        public string hoTen;
        public int namSinh;

        public string HoTen()
        {
            return hoTen;
        }

        public int NamSinh()
        {
            return namSinh;
        }

        public SinhVien(string hoTen, int namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        public int xuLyTuoi()
        {
            System.DateTime Year = System.DateTime.Now;
            int temp = Year.Year;
            int oldSinhVien = temp - namSinh;
            return oldSinhVien;
        }

        public static int xuLyTuoiTinh(SinhVien sv)
        {
            System.DateTime Year = System.DateTime.Now;
            int temp = Year.Year;
            int oldSinhVien = temp - sv.namSinh;
            return oldSinhVien;
        }
    }
}
