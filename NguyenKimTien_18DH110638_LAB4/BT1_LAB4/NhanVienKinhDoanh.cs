using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB4
{
    class NhanVienKinhDoanh : NhanVien
    {
        private int soLuongHopDong;
        private int luongCoBan;

        public int SoLuongHopDong { get => soLuongHopDong; set => soLuongHopDong = value; }
        public int LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public NhanVienKinhDoanh(string maNV, string hoTen) : base(maNV, hoTen) { }

        public override int TinhLuong()
        {
            return luongCoBan + soLuongHopDong * 500000;
        }
    }
}
