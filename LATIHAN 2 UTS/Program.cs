// ZAQKI HIDAYAT
// 2207111396
using System;

namespace UTS
{
    class nodua
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rate USD ke RP:");
            double HargaUSD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jumlah USD");
            double JumlahRP = Convert.ToDouble(Console.ReadLine());

            double Hasil = HargaUSD * JumlahRP;
            Console.WriteLine("Hasil Konversi : RP."+Hasil);
            Console.ReadLine();
        }
    }
}