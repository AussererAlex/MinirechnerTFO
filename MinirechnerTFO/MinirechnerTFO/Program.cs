using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  + Minirechner +");
            Console.Write("\nGeben Sie Zahl1 ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie Zahl2 ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            //Ergebnisse
            Console.WriteLine("----------------------");
            int ErgA = Addition(Zahl1, Zahl2);
            Console.WriteLine("\nDas Ergebniss der Addition beträgt: "+ErgA);
            int ErgS = Suptraktion(Zahl1, Zahl2);
            Console.WriteLine("Das Ergebniss der Suptraktion beträgt: " + ErgS);
            int ErgM = Multiplikation(Zahl1, Zahl2);
            Console.WriteLine("Das Ergebniss der Multiplikation beträgt: " + ErgM);

            Console.ReadKey();

            
        }
        public static int Addition(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 + Zahl2;
            return Erg;
        }
        public static int Suptraktion(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 - Zahl2;
            return Erg;
        }
        public static int Multiplikation(int Zahl1, int Zahl2)
        {
            int Erg = Zahl1 * Zahl2;
            return Erg;
        }
    }

}