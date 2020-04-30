using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            View();
        }

        public void View()
        {
            this.radioNVKD.Enabled = true;
            this.txtSoLuongSP.Enabled = false;
        }

        public void ClearNVKD()
        {
            this.txtLuongCoBan.Text = "";
            this.txtSoLuongHD.Text = "";
            this.KQLuongNV.Text = "";
        }

        public void ClearNVSX()
        {
            this.txtSoLuongSP.Text = "";
            this.KQLuongNV.Text = "";
        }

        private void radioNVKD_CheckedChanged(object sender, EventArgs e)
        {
            ClearNVSX();
            this.radioNVKD.Enabled = true;
            this.txtSoLuongSP.Enabled = false;
            this.txtLuongCoBan.Enabled = true;
            this.txtSoLuongHD.Enabled = true;
        }

        private void radioNVSX_CheckedChanged(object sender, EventArgs e)
        {
            ClearNVKD();
            this.radioNVSX.Enabled = true;
            this.txtLuongCoBan.Enabled = false;
            this.txtSoLuongHD.Enabled = false;
            this.txtSoLuongSP.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien;
            string maNhanVien = txtMaNhanVien.Text;
            string hoTen = txtHoTen.Text;
            bool isCheckNhanVien = radioNVKD.Checked;

            if (isCheckNhanVien)
            {
                int luongCoBan = int.Parse(txtLuongCoBan.Text);
                int soLuongHD = int.Parse(txtSoLuongHD.Text);

                nhanvien = new NhanVienKinhDoanh(maNhanVien, hoTen, luongCoBan, soLuongHD);
            }
            else
            {
                int soLuongSP = int.Parse(txtSoLuongSP.Text);

                nhanvien = new NhanVienSanXuat(maNhanVien, hoTen, soLuongSP);
            }

            this.KQLuongNV.Text = nhanvien.TinhLuong().ToString();
        }
    }
}
