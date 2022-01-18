using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku numbri;
            //Kasutaja peab selle numbri ära arvama;
            //Kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud;
            //Kasutajal on kolm katset
            //Kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis võidab mängu arvuti
            //Programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (i < 3)
            {
                Console.WriteLine("Sisesta arvatav number");
                int usernumber = Convert.ToInt32(Console.ReadLine());

                if (usernumber == cpuNumber)
                {
                    Console.WriteLine("Tubli, arvasid ära. Oled võitnud!");

                    break;
                }
                else
                {

                    i++;
                    Console.WriteLine($"Vale number, proovi uuesti {3 - i} katset jaanud!");

                }


            }


            Console.WriteLine($"Arvatav number oli {cpuNumber}");
            Console.WriteLine("Kena paeva jatku!");
        }
    }
}
