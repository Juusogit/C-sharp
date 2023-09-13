using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele muuttuja pii, jolle annat alkuarvoksi piin likiarvon 6 desimaalin tarkkuudella.
Lue käyttäjältä ympyrän halkaisija ja tulosta ympyrän piiri ja pinta-ala kolmen desimaalin
tarkkuudella seuraavasti (halkaisijaksi annettu 2,5) :

PIIRI     : 7,854
PINTA-ALA : 4,909 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double pii = 3.141592;
            double halkaisija, piiri, pinta_ala;

            Console.Write("Anna ympyrän halkaisija senttimetreinä: ");
            halkaisija = double.Parse(Console.ReadLine());

            piiri = pii * halkaisija;
            pinta_ala = (pii / 4) * (halkaisija * halkaisija);

            Console.WriteLine("PIIRI     : " + piiri.ToString("f3"));
            Console.WriteLine("PINTA-ALA : " + pinta_ala.ToString("F3"));
        }
    }
}