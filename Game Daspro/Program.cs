using System;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Selamat Datang di dunia Isekai --");
            Console.WriteLine("Silahkan Tulis namamu!");
            Pemula player = new Pemula();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+player.Name+", Siap untuk memulai Permainan?[ya/tidak]");
            string bMulai = Console.ReadLine();
            if(bMulai == "ya")
            {
                Console.WriteLine(player.Name+" Sedang masuk ke dunia Isekai...");
                Enemy enemy1 = new Enemy("Kupu-Kupu");
                Console.WriteLine(player.Name+" Sedang menghadapi "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" MenyerangMu...");
                Console.WriteLine("Pilih apa yang ingin anda lakukan...");
                Console.WriteLine("1. Serangan Tunggal");
                Console.WriteLine("2. Serangan ayunan");
                Console.WriteLine("3. Bertahan");
                Console.WriteLine("4. Melarikn diri");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        Console.WriteLine(player.Name+" Sedang melakukan serangan tunggal");
                        enemy1.KenaPukul(player.AttackPower);
                        player.Exp += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.KenaPukul(enemy1.AttackPower);
                        Console.Write("Hp Pemain : "+player.Health+" | Hp Musuh : "+enemy1.Health+"\n");
                        break;
                        case "2" :
                        player.Berputar();
                        player.Exp += 0.9f;
                        enemy1.KenaPukul(player.AttackPower);
                        Console.Write("Hp Pemain : "+player.Health+" | Hp Musuh  : "+enemy1.Health+"\n");
                        break; 
                        case "3" :
                        player.Istirahat();
                        Console.WriteLine("Musuh Sedang dipulihkan... ");
                        enemy1.Attack(enemy1.AttackPower);
                        player.KenaPukul(enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" Sedang melarikan diri...");
                        break;
                    }
                    continue;
                }
                
                Console.WriteLine(player.Name+" dapatkan"+player.Exp+" titik Exp.");
            }
            else
            {
                Console.WriteLine("Selamat Tinggal.."); 
                Console.Read();
            }
        }
    }

    class Pemula
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Exp { get; set; }
        Random rnd = new Random();

        public Pemula(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Exp = 0f;
            Name = "Unknown";
        }

        public void Berputar(){
            if(SkillSlot > 0){
                Console.WriteLine("Berputar!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
            }else{
                Console.WriteLine("Kamu tidak memiliki energi!");
            }
        }

        public void KenaPukul(int hitValue){
            Console.WriteLine(Name+" terkena "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Mati();
            }
        }

        public void Istirahat(){
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Mati(){
            Console.WriteLine("Kamu telah mati. Permainan Selesai!");
            IsDead = true;
        }      
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name){
            Health = 50;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }
        
        public void KenaPukul(int hitValue){
            Console.WriteLine(Name+" terkena "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Mati();
            }
        }

        public void Mati(){
            Console.WriteLine(Name +" telah mati");
            IsDead = true;
        }
    }
}