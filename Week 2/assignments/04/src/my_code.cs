using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä kaksi kokonaislukua sekä operaatio joka lukujen välillä
suoritetaan (voi olla +, -, * tai / eli kyseessä siis nelilaskin).

Käytä operaation tallentamiseen string-tyyppistä muuttujaa.

Tutki switch-case rakenteessa minkä operaation käyttäjä syötti ja
tulosta sen perusteella lukujen laskutoimitus vastauksineen. Osamäärä
tulostetaan kahden desimaalin tarkkuudella

Esimerkiksi
jos käyttäjä syöttää luvut "12" ja "13" ja operaatioksi "+" niin tulostetaan

12 + 13 = 25

Jos operaatio oli annettu väärin, niin tulosta virheilmoitus
"annoit operaation väärin"

Nollalla jakoa ei saa ohjelmassa tapahtua, vaan silloin tulostetaan
"Nollalla jako, ei voida suorittaa"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä ensimmäinen luku: ");
            int luku1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            int luku2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Syötä operaatio (+, -, *, /): ");
            string operaatio = Console.ReadLine();

            double tulos = 0;

            switch (operaatio)
            {
                case "+":
                    tulos = luku1 + luku2;
                    Console.WriteLine($"{luku1} + {luku2} = {tulos}");
                    break;
                case "-":
                    tulos = luku1 - luku2;
                    Console.WriteLine($"{luku1} - {luku2} = {tulos}");
                    break;
                case "*":
                    tulos = luku1 * luku2;
                    Console.WriteLine($"{luku1} * {luku2} = {tulos}");
                    break;
                case "/":
                    if (luku2 != 0)
                    {
                        tulos = (double)luku1 / luku2;
                        Console.WriteLine($"{luku1} / {luku2} = {tulos:f2}");
                    }
                    else
                    {
                        Console.WriteLine("Nollalla jako, ei voida suorittaa");
                    }
                    break;
                default:
                    Console.WriteLine("annoit operaation väärin\n");
                    break;
            }
        }
    }
}