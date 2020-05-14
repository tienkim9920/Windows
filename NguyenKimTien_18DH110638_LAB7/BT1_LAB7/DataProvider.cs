using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BT1_LAB7
{
    class DataProvider
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["QLQuan"].ConnectionString.ToString();

        SqlConnection connection;
        public void ListSanPham()
        {
            connection = new SqlConnection(connectionString);
            string queryString = "Select * From ThucUong;";
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                    reader[0], reader[1], reader[2], reader[3]);
            }
            reader.Close();
        }

        public void ThemSanPham(string MSHH, string TenHang, int Gia, bool TinhTrang)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "INSERT INTO ThucUong (MSHH, TenHang, Gia, TinhTrang)" + "VALUES (@MSHH, @TenHang, @Gia, @TinhTrang);";

            string mshh = MSHH;
            string tenHang = TenHang;
            int gia = Gia;
            bool tinhTrang = TinhTrang;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@TenHang", tenHang);
            command.Parameters.AddWithValue("@Gia", gia);
            command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void XoaSanPham(string MSHH)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "DELETE FROM ThucUong WHERE MSHH=@MSHH";

            string mshh = MSHH;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void SuaSanPham(string MSHH)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "UPDATE ThucUong SET TenHang = @TenHang, Gia= @Gia WHERE MSHH=@MSHH";

            string mshh = MSHH;
            Console.Write("Nhap Ten Hang Hoa Can Sua: ");
            string tenHang = Console.ReadLine();
            Console.Write("Nhap Gia Can Sua: ");
            string gia = Console.ReadLine();

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@TenHang", tenHang);
            command.Parameters.AddWithValue("@Gia", gia);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }
            
        public void ListHoaDon()
        {
            connection = new SqlConnection(connectionString);
            string queryString = "Select * From HoaDon;";
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}",
                    reader[0], reader[1]);
            }
            reader.Close();
        }

        public void TaoHoaDon(string MSDH, string dateTime)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "INSERT INTO HoaDon (MSDH, NgayDat) VALUES (@MSDH, @NgayDat);";

            string msdh = MSDH;
            string ngayDat = dateTime;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSDH", msdh);
            command.Parameters.AddWithValue("@NgayDat", ngayDat);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void TaoHDChiTiet(string MSHD, string MSHH, int SoLuong, int TiLeGiam)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "INSERT INTO HDChiTietDatHang (MSHD, MSHH, SoLuong, TiLeGiam) VALUES (@MSHD, @MSHH, @SoLuong, @TiLeGiam);";


            string mshh = MSHH;
            string mshd = MSHD;
            int soLuong = SoLuong;
            int tiLeGiam = TiLeGiam;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHD", mshd);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@SoLuong", soLuong);
            command.Parameters.AddWithValue("@TiLeGiam", tiLeGiam);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void LietKeChiTiet()
        {
            connection = new SqlConnection(connectionString);
            string queryString = "Select * From HDChiTietDatHang;";
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                    reader[0], reader[1], reader[2], reader[3]);
            }
            reader.Close();
        }
    }
}
