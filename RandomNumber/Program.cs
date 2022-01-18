using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku numbri;
            //Kui genereeritud number on viis, lõpetab programm töö ja soovib kasutajale "Kena päeva!";
            //Kui genereeritud number on midagi muud, siis programm jätkab oma tööd;

            Random rnd = new Random();
            int i = 0;

            while(i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");
            
        }
    }
}
