using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_LAB7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["QLQuan"].ConnectionString.ToString();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string queryString = "Select * From ThucUong;";
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(0).ToString());
                lv.SubItems.Add(reader.GetString(1).ToString());
                lv.SubItems.Add(reader.GetInt32(2).ToString());
                lv.SubItems.Add(reader.GetBoolean(3).ToString());

                listView1.Items.Add(lv);
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdate FUpdate = new FormUpdate();
            FUpdate.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete FDelete = new FormDelete();
            FDelete.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit FEdit = new FormEdit();
            FEdit.ShowDialog();
        }
    }
}
