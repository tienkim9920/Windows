using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB5
{
    class NhanVienSanXuat : NhanVien
    {
        private int soLuongSanPham;

        public int SoLuongSanPham { get => soLuongSanPham; set => soLuongSanPham = value; }

        public NhanVienSanXuat(string maNV, string hoTen, int soLuongSanPham) : base(maNV, hoTen)
        {
            this.soLuongSanPham = soLuongSanPham;
        }

        public override int TinhLuong()
        {
            int kq = soLuongSanPham * 1000;
            if (soLuongSanPham >= 3000)
            {
                kq = (int)(kq * 1.05);
            }
            return kq;
        }
    }
}
