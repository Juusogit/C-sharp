using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele 3 alkioinen double taulukko ja lue siihen käyttäjältä arvot. 
Tulosta lopuksi syötettyjen lukujen summa ja keskiarvo seuraavasti:

SUMMA :     12.23
KESKIARVO : 4.07
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double[] dTaulukko = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Syötä luku " + (i + 1) + ": ");
                dTaulukko[i] = double.Parse(Console.ReadLine());
            }

            double summa = 0;
            for (int i = 0; i < 3; i++)
            {
                summa += dTaulukko[i];
            }

            double keskiarvo = summa / 3;

            Console.WriteLine("SUMMA :     " + summa);
            Console.WriteLine("KESKIARVO : " + keskiarvo.ToString("f2"));
        }
    }
}