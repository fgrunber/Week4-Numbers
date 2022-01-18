using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada PIN-koodi;
            //Programm võrdleb sisestatud PIN-koodi arvuga 1234;
            //Kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //Katsete arv on piiramatu.

            bool loopActive = true;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }   
    }
}
