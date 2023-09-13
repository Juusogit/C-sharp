using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä koenumero 4-10 väliltä. Jos käyttäjä syötti arvosanan väärin,
niin tulosta "et antanut arvosanaa annetulta väliltä". Muussa tapauksessa tulosta:

"hyvä", jos arvosana oli 9 tai 10
"kelpo", jos 7-8
"tyydyttävä", jos 5-6
"heikko", jos 4

Toteuta ohjelma if-rakenteella
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä koenumero: ");
            int koenumero = Convert.ToInt32(Console.ReadLine());

            if (koenumero < 4 || koenumero > 10)
            {
                Console.WriteLine("et antanut arvosanaa annetulta väliltä.\n");
            }
             if (koenumero == 9 || koenumero == 10)
            {
                Console.WriteLine("hyvä");
            }
             if (koenumero == 7 || koenumero == 8)
            {
                Console.WriteLine("kelpo");
            }
             if (koenumero == 5 || koenumero == 6)
            {
                Console.WriteLine("tyydyttävä");
            }
             if (koenumero == 4)
            {
                Console.WriteLine("heikko");
            }
        }
    }
}