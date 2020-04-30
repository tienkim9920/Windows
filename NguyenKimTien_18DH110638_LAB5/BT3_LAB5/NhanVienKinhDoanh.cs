using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB5
{
    class NhanVienKinhDoanh : NhanVien
    {
        private int soLuongHopDong;
        private int luongCoBan;

        public int SoLuongHopDong { get => soLuongHopDong; set => soLuongHopDong = value; }
        public int LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public NhanVienKinhDoanh(string maNV, string hoTen, int luongCoBan, int soLuongHopDong) : base(maNV, hoTen)
        {
            this.luongCoBan = luongCoBan;
            this.soLuongHopDong = soLuongHopDong;
        }

        public override int TinhLuong()
        {
            return luongCoBan + soLuongHopDong * 500000;
        }
    }
}
