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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mshh = txtMSHH.Text;

            DataProvider data = new DataProvider();
            data.XoaSanPham(mshh);

            MessageBox.Show("Bạn Đã Xóa Thành Công", "Thông Báo!");
            txtMSHH.Text = "";
        }

        private void FormDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }
    }
}
