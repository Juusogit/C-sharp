using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä kokonaislukuja while-silmukassa, kunnes käyttäjä syöttää arvon -1. 
Sen jälkeen tulosta syötettyjen lukujen keskiarvo yhden desimaalin tarkkuudella
alla olevalla tavalla:

"Keskiarvo : 12.1"

Lukua -1 ei oteta keskiarvon laskentaan mukaan.

Jos käyttäjä ei syöttänyt yhtään lukua, niin keskiarvoa ei saa tulostaa
vaan silloin tulostetaan

"Et antanut yhtään lukua"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int summa = 0;
            int lukumaara = 0;
            int luku;

            Console.WriteLine("Syötä kokonaislukuja. Lopeta syöttämällä -1.");

            while (true)
            {
                luku = int.Parse(Console.ReadLine());

                if (luku == -1)
                {
                    break;
                }

                summa += luku;
                lukumaara++;
            }

            if (lukumaara > 0)
            {
                double keskiarvo = (double)summa / lukumaara;
                Console.WriteLine("Keskiarvo: " + keskiarvo.ToString("f1"));
            }
            else
            {
                Console.WriteLine("Et antanut yhtään lukua");
            }
        }
    }
}