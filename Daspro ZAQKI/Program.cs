// Di buat OLeh ZAQKI HIDAYAT
using System;

namespace DasPro
{
    class Program
    {
        static int k1,k2,k3,j1,j2,level,lvl,tingkatan,jumlahKode;
        static string t1,t2,t3;
        static bool GameStart;
        static void Main(string[] args)
        {
            Intro();
            while(lvl > 0 && level <= 5)
            {
                GameStart = playgame(level);
                if(GameStart)
                {
                    level++;
                    if(level <= 5)
                    {
                        Console.WriteLine("Level meningkat ke "+level);
                    }
                } else
                {
                    lvl--;
                    Console.WriteLine("Tebakan Anda Tersisa "+lvl);
                }

                if(level > 5 && lvl > 0)
                {
                    Console.WriteLine("Selamat !!!\nAnda telah Menang.");
                } else if(lvl <= 0 && level == 1)
                {
                    Console.WriteLine("Mohon Sabar\nAnda telah Kalah.");
                }
            }
            Console.ReadKey();
        }

        static void Intro()
        {
            level = 1;
            lvl = 3;
            GameStart = true;
        }

        static bool playgame(int tingkatan)
        {
            Random rng = new Random();
            k1 = rng.Next(1,tingkatan+1);
            k2 = rng.Next(1,tingkatan+1);
            k3 = rng.Next(1,tingkatan+1);

            jumlahKode = 3;

            j1=k1+k2+k3;
            j2=k1*k2*k3;

            Console.WriteLine("Selamat Datang Agen Rahasia");
            Console.WriteLine("Anda harus memecahkan password untuk masuk ke dalam markas Bjorka");
            Console.WriteLine("Password terdiri dari "+jumlahKode+" angka");
            Console.WriteLine("jika Ditambahkan hasilnya "+j1);
            Console.WriteLine("jika Dikalikan hasilnya "+j2);

            Console.Write("Ketikkan Kode Pertama :  ");
            t1 = Console.ReadLine();
            Console.Write("Ketikkan Kode Kedua :  ");
            t2 = Console.ReadLine();
            Console.Write("Ketikkan Kode Ketiga :  ");
            t3 = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+t1+" "+t2+" "+t3+"?");

            if(t1 == k1.ToString() && t2 == k2.ToString() && t3 == k3.ToString())
            {
               Console.WriteLine("Selamat, Jawaban anda betul...\n\n");
               return true;
            }
            else
            {
                Console.WriteLine("Mohon Sabar, Jawaban anda salah...\n\n");
                return false;
            } 
        }
    }
}
