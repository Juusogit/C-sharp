using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele kaksi kokonaislukumuuttujaa ja lue niihin käyttäjältä arvot.
Tulosta näiden muuttujien summa, erotus ja tulo alla olevalla tavalla
(HUOM! Laskutoimituksen tulostus alkaa kaikissa samasta kohdasta!)

Summa :  10 + 5 = 15
Erotus : 10 - 5 = 5
Tulo :   10 * 5 = 50
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int luku1, luku2;

            Console.Write("Anna ensimmäinen kokonaisluku: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku: ");
            luku2 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;

            Console.WriteLine("Summa :  " + luku1 + " + " + luku2 + " = " + summa);
            Console.WriteLine("Erotus : " + luku1 + " - " + luku2 + " = " + erotus);
            Console.WriteLine("Tulo :   " + luku1 + " * " + luku2 + " = " + tulo);
        }
    }
}