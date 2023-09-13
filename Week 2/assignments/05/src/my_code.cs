using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä ympyrän säde liukulukuna.

Kysy käyttäjältä myös, haluaako hän tehdä kumpaa seuraavista
(eli käyttäjä syöttää joko numeron 1 tai 2) :

    1 = laske ympyrän piiri
    2 = laske ympyrän pinta-ala

Tämän vastauksen perusteella laske dTulos-muuttujaan joko piiri
tai pinta-ala ja tulosta se. 

Toteuta tämä sekä if-rakenteella että ehdollisella operaattorilla.
Tulostus pitää siis tehdä kaksi kertaa alla olevalla tavalla:

Tulos : 12.22
Tulos : 12.22
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä ympyrän säde: ");
            double sade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valitse laskettava arvo (1=piiri, 2=pinta-ala): ");
            int valinta = Convert.ToInt32(Console.ReadLine());

            double dTulos;

            if (valinta == 1)
            {
                dTulos = 2 * Math.PI * sade;
                Console.WriteLine($"Tulos : {dTulos:f2}");
            }
            else if (valinta == 2)
            {
                dTulos = Math.PI * sade * sade;
                Console.WriteLine($"Tulos : {dTulos:f2}");
            }
            else
            {
                Console.WriteLine("Virheellinen valinta.");
            }
        }
    }
}