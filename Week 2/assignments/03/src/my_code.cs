using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Tee ohjelma, joka pyytää käyttäjää syöttämään lampotila -nimiseen muuttujaan
jonkin mielivaltainen lämpötilan arvon (mieti tyyppi tarkasti kun ensin katsot alla olevaa...).

Ohjelma tulostaa sitten seuraavasti, kun lämpötila on:

> 39 tulostuu : "liian kuuma"
11..39 tulostuu : "lämmintä"
0..10 tulostuu : "haaleaa"
-30..-1 tulostuu : "pakkasta"
< -30 tulostuu : "liian kylmä"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä lämpötila: ");
            double lampotila = Convert.ToDouble(Console.ReadLine());

            if (lampotila > 39)
            {
                Console.WriteLine("liian kuuma");
            }
            else if (lampotila >= 11 && lampotila <= 39)
            {
                Console.WriteLine("lämmintä");
            }
            else if (lampotila >= 0 && lampotila <= 10)
            {
                Console.WriteLine("haaleaa");
            }
            else if (lampotila >= -30 && lampotila <= -1)
            {
                Console.WriteLine("pakkasta");
            }
            else if (lampotila < -30)
            {
                Console.WriteLine("liian kylmä");
            }
        }
    }
}