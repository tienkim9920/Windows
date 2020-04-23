using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            PhongBan newPhongBan = new PhongBan(2);
            newPhongBan.KhoiTaoNhanVien();
            newPhongBan.TongLuongPhongBan();
            Console.WriteLine();
        }
    }
}
