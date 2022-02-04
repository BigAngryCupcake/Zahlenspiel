using System;
using System.IO;

namespace Zahlenspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;
            int richtig;

            Console.WriteLine("");
            Console.WriteLine("Willkommen beim Zahlen-Spiel.");

            Random rand = new Random();
            richtig = rand.Next(1, 100);



            while (eingabe != richtig)
            {

            a:
                Console.WriteLine("");
                Console.WriteLine("Gib eine Zahl ein:");
                Console.WriteLine("");

                string eingabe_str = Console.ReadLine();



                if (eingabe_str == "")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine($"Depp, gib eine Zahl ein");
                    goto a;

                }



                try
                {
                    eingabe = Convert.ToInt32(eingabe_str);
                }


                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine($"Depp, gib eine Zahl ein");
                    goto a;
                }




                if (eingabe < richtig)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine($"{eingabe} zu klein");
                    Console.WriteLine("");
                }


                if (eingabe > richtig)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine($"{eingabe} zu groß");
                    Console.WriteLine("");
                }



            }

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"{eingabe} Richtig");
            Console.WriteLine("");
        }
    }
}
