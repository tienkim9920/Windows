using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_LAB1
{
    class SinhVien
    {
        public string maSV;
        public string hoTen;
        public string diaChi;
        public int namSinhVien;

        public SinhVien(string maSV, string hoTen, string diaChi, int namSinhVien)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.namSinhVien = namSinhVien;
        }

        public string OutPut()
        {
            return "Ma Sinh Vien: " + maSV + "\nHo Ten: " + hoTen + "\nDia Chi: " + diaChi + "\nSinh Vien Nam Thu: " + namSinhVien;
        }
    }
}
