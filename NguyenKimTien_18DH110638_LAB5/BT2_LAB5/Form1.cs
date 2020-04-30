using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tuSoA = int.Parse(this.txtTuSoA.Text);
            int mauSoA = int.Parse(this.txtMauSoA.Text);

            int tuSoB = int.Parse(this.txtTuSoB.Text);
            int mauSoB = int.Parse(this.txtMauSoB.Text);

            int TuSo = tuSoA * mauSoB + tuSoB * mauSoA;
            int MauSo = mauSoA * mauSoB;

            this.KQTuSo.Text = TuSo.ToString();
            this.KQMauSo.Text = MauSo.ToString();
        }
    }
}
