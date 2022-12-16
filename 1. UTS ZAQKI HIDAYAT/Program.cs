//HelloWorld! program
using System;
namespace HelloWorld
{
    //ZAQKI HIDAYAT
    class Program
    {
        static void Main(string[] args)
        {
            //cara ngoding
            const int a = 2;
            const int b = 1;
            const int c = 5;

            int tambah = a+b+c;
            int kali = a*b*c;
            int kurang = a-b-c;
            int bagi = a/b/c;

            Console.WriteLine("Anda adalah agen rahasia yag bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Passsword terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya "+ tambah);
            Console.WriteLine("- Jika dikalikan hasilnya "+ kali);
            Console.WriteLine("- Jika dikurangkan hasilnya "+ kurang);
            Console.WriteLine("- Jika dibagi hasilnya "+ bagi);

            Console.WriteLine("");
            Console.WriteLine("Enter code : ");

        }
    }
}
