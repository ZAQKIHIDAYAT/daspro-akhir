using System;

namespace New_folder__2_
{
    class Program
    {
        static Random rand = new Random();
        static int pc, Hm, mpc, mHm;

        static void Main(string[] args)
        {
            Console.WriteLine("dadu");

            for (int i = 0; i < 10; i++){
                playGame();
            }

            Console.WriteLine($"skor anda {mHm} dan skor pc {mpc}");
        }

        static void playGame(){

            pc = rand.Next(1, 7);
            Hm = rand.Next(1, 7);
            Console.ReadLine();

            if(Hm > pc){
                mHm = mHm + 1;
                Console.WriteLine("manusia menang");
            } else if(Hm == pc){
                Console.WriteLine("draw");
            } else {
                mpc = mpc + 1;
                Console.WriteLine("anda kalah");
            }


        }
    }
}
