using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele 10 alkioinen int taulukko ja arvo siihen lukuja väliltä 0-10. 
Vain parilliset luvut sallitaan.Jos arvottiin pariton luku niin sen 
tilalle on arvottava uusi luku.

Tulosta luvut ensin taulukon alusta loppuun tabulaattorilla eroteltuna
ja seuraavalla rivillä lopusta alkuun tabulaattorilla eroteltuna
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int[] taulukko = new int[10];

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int luku;
                do
                {
                    luku = random.Next(0, 11);
                } while (luku % 2 != 0);

                taulukko[i] = luku;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(taulukko[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 9; i >= 0; i--)
            {
                Console.Write(taulukko[i] + "\t");
            }

            Console.WriteLine();
        }
    }
}