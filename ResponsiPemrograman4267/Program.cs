using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4267
{
    class Program
    {
        static void Main(string[] args)
        {
            var krywn1 = new karyawan(190302123, "Paijo", 3000000);
            var krywn2 = new karyawan(190302124, "Jono", 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); krywn1.tampilkanData();
            Console.Write("2 "); krywn2.tampilkanData();
            Console.WriteLine();

            krywn1.naikGaji();
            krywn2.naikGaji();

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.Write("1 "); krywn1.tampilkanData();
            Console.Write("2 "); krywn2.tampilkanData();

        }
    }
}
