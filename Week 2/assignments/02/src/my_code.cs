using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä kuukauden numero.
Tulosta sen jälkeen onko nyt "syksy", "talvi", "kevät" vai "kesä".
Käytä switch-case rakennetta. Jos käyttäjä syötti kuukauden numeron väärin, niin tulosta
"et antanut kuukauden numeroa oikein"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä kuukauden numero: ");
            int kuukausi = Convert.ToInt32(Console.ReadLine());

            switch (kuukausi)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("talvi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("syksy");
                    break;
                default:
                    Console.WriteLine("et antanut kuukauden numeroa oikein.");
                    break;
            }
        }
    }
}