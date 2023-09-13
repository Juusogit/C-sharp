using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä mistä luvusta tulostetaan ja mihin asti ja millaisella askelluksella. 

HUOM! Mistä on oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0.
Muuten kysyttävä tiedot uudestaan.

Tulosta lukusarjat sekä while-, do-while- että for-silmukoilla. 

Esimerkki:
Jos mistä on 5, mihin on 11 ja askellus on 2, niin ohjelma tulostaa kaikilla
kolmella silmukalla saman, alla olevan lukusarjan (lukujen välissä kaksi välilyöntiä).
Tulosta myös millä silmukalla luvut on tulostettu. 

WHILE:
5  7  9  11

DO-WHILE:
5  7  9  11

FOR:
5  7  9  11
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int mista, mihin, askellus;

            // Kysytään luvut käyttäjältä
            do
            {
                Console.Write("Syötä luku, josta lähdetään tulostamaan: ");
                mista = int.Parse(Console.ReadLine());

                Console.Write("Minne asti herra haluaa tulostaa?: ");
                mihin = int.Parse(Console.ReadLine());

                Console.Write("Ja vielä monenko numeron välein lukusi tulostetaan?: ");
                askellus = int.Parse(Console.ReadLine());

                if (mista >= mihin || askellus <= 0)
                {
                    Console.WriteLine("Minua et voi huijata :). Yritä uudelleen.");
                }
            } while (mista >= mihin || askellus <= 0);

            Console.WriteLine();

            // While-silmukka
            Console.WriteLine("WHILE:");
            int i = mista;
            while (i <= mihin)
            {
                Console.Write(i + "  ");
                i += askellus;
            }
            Console.WriteLine();
            Console.WriteLine();

            // Do-While-silmukka
            Console.WriteLine("DO-WHILE:");
            i = mista;
            do
            {
                Console.Write(i + "  ");
                i += askellus;
            } while (i <= mihin);
            Console.WriteLine();
            Console.WriteLine();

            // For-silmukka
            Console.WriteLine("FOR:");
            for (i = mista; i <= mihin; i += askellus)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
    }
}