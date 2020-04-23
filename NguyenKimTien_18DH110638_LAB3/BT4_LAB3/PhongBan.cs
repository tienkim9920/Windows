using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_LAB3
{
    class PhongBan
    {
        NhanVien[] phongBan;

        public int soLuongNhanVien;

        public PhongBan()
        {
            phongBan = new NhanVien[0];
        }

        public PhongBan(int soLuongNhanVien)
        {
            phongBan = new NhanVien[soLuongNhanVien];
            this.soLuongNhanVien = soLuongNhanVien;

            for (int i = 0; i < this.soLuongNhanVien; i++)
            {
                this[i] = new NhanVien();
            }
        }

        public NhanVien this[int i]
        {
            get { return phongBan[i]; }
            set
            {
                phongBan[i] = value;
            }
        }

        public void KhoiTaoNhanVien()
        {
            Console.WriteLine("###Vui Long Nhap Thong Tin Nhan Vien###");
            for (int i = 0; i < this.soLuongNhanVien; i++)
            {
                NhanVien nNhanVien = this[i];
                Console.WriteLine("###Nhan Vien Thu {0}###", i + 1);
                Console.Write("Nhap Ho Ten: ");
                nNhanVien.hoTen = Console.ReadLine();
                Console.Write("Nhap Muc Luong: ");
                nNhanVien.mucLuong = double.Parse(Console.ReadLine());
                Console.Write("Nhap So Ngay Vang: ");
                nNhanVien.soNgayVang = int.Parse(Console.ReadLine());
            }
        }

        public void TongLuongPhongBan()
        {
            double kq = 0;
            Console.Write("\nTong Luong Phong Ban La: ");
            for (int i = 0; i < this.soLuongNhanVien; i++)
            {
                NhanVien nNhanVien = this[i];
                kq += this[i].luong();
            }
            Console.Write(kq);
        }
    }
}
