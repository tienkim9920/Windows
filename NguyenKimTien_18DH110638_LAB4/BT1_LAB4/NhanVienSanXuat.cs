using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB4
{
    class NhanVienSanXuat : NhanVien
    {
        private int luongCoBan;
        private int soLuongSanPham;

        public int LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public int SoLuongSanPham { get => soLuongSanPham; set => soLuongSanPham = value; }

        public NhanVienSanXuat(string maNV, string hoTen) : base(maNV, hoTen) { }

        public override int TinhLuong()
        {
            int kq = luongCoBan + soLuongSanPham * 1000;
            if (soLuongSanPham >= 3000)
            {
                kq = (int)(kq * 1.05);
            }
            return kq;
        }
    }
}
