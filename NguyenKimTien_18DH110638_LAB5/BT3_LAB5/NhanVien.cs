using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB5
{
    abstract class NhanVien
    {
        public string maNV;
        public string hoTen;

        public NhanVien(string maNV, string hoTen)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
        }

        public NhanVien()
        {
            maNV = "18DH110638";
            hoTen = "Nguyen Kim Tien";
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public abstract int TinhLuong();
    }
}
