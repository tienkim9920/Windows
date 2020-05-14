using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_LAB7
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Hide();
                Form1 F1 = new Form1();
                F1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mshh = txtMSHH.Text;
            string tenSanPham = txtTenSanPham.Text;
            int gia = int.Parse(txtGia.Text);
            bool tinhTrang = radioConHang.Checked ? true : false;

            DataProvider data = new DataProvider();
            data.ThemSanPham(mshh, tenSanPham, gia, tinhTrang);

            MessageBox.Show("Bạn Đã Thêm Thành Công", "Thông Báo!");
            Clear();
        }

        public void Clear()
        {
            txtMSHH.Text = "";
            txtGia.Text = "";
            txtTenSanPham.Text = "";
            radioConHang.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
