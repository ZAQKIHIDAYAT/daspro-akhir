//Create By Zaqki Hidayat
//NIM 2207111396
using System;
using System.Collections.Generic;

namespace DasPro
{
    class Program
    {
        static int kesempatan = 5;
        static String karakterMisteri = "doutmun";
        static List<string> listTebakan = new List<String>{};

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
        }

        static void Intro()
        {
            Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak kata");
            Console.WriteLine("Kamu punya : "+kesempatan+" kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("Petunjuknya adalah kata ini merupakan nama klub sepakbola");
            Console.WriteLine($"kata tersebut terdiri dari : {karakterMisteri.Length} huruf");
            Console.WriteLine("klub apakah yang dimaksud?");
        }

        static void PlayGame()
        {
            while(kesempatan>0)
            {
                Console.Write("Apa huruf tebakanmu?(pilih a-z) : ");
                String input = Console.ReadLine();
                listTebakan.Add(input);
                if(CekJawaban(karakterMisteri, listTebakan)){
                    Console.WriteLine("\nselamat! anda menang");
                    Console.WriteLine($"kata misteri hari ini adalah : {karakterMisteri}");
                    break;
                    
                }else if(karakterMisteri.Contains(input)){
                    Console.WriteLine("\nHuruf itu ada di dalam kata ini");
                    Console.WriteLine(cekhuruf(karakterMisteri,listTebakan));
                    Console.WriteLine("Silahkan tebak huruf lainnya... ");
                } else{
                    Console.WriteLine("\nHuruf itu tidak ada dalam kata ini");
                    kesempatan--;//kesempatan = kesempatan - 1;
                    Console.WriteLine($"Kesempatan anda tinggal {kesempatan}");
                    //Menampilkan huruf yang sudah tertebak
                }
                if(kesempatan == 0){
                    Endgame();
                    break;
                }
            }
        }

        static bool CekJawaban(string katarahasia, List<string> list){
            bool  Status = false;

            for (int i = 0; i < katarahasia.Length; i++)
            {
                string c = Convert.ToString(katarahasia[i]);
                if(list.Contains(c)){
                    Status = true;
                }else{
                    Status = false;
                }
            }

            return Status;
        }

        static string cekhuruf(string katarahasia, List<string> list){
            string x = "";

            for (int i = 0; i < katarahasia.Length; i++)
            {
                string c = Convert.ToString(katarahasia[i]);
                if (list.Contains(c))
                {
                    x = x + c;
                } else{
                    x = x + "_";
                }
            }

            return x;

        }

        static void Endgame(){
            Console.WriteLine("\nPermainan berakhir.");
            Console.WriteLine($"kata misteri sebenarnya adalah : {karakterMisteri}");
            Console.WriteLine("Bye...");
        }
    }
    
}
