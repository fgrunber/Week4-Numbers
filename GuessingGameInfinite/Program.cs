using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku numbri;
            //Kasutaja peab selle numbri ära arvama;
            //Kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud;
            //Katsete arv on piiramatu
            //Programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta arvatav number");
                int usernumber = Convert.ToInt32(Console.ReadLine());

                if (usernumber == cpuNumber)
                {
                    Console.WriteLine("Tubli, arvasid ära. Oled võitnud.");

                    break;
                }
                else
                {

                    i++;
                    Console.WriteLine($"Vale number, proovi uuesti");

                }


            }


            Console.WriteLine($"Arvatav number oli {cpuNumber}");
            Console.WriteLine("Kena paeva!");
        }
    }
}
