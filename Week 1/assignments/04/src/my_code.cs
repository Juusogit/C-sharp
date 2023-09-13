using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele nimi, pituus ja paino muuttujat. Esittele lisäksi bmi muuttuja.
Kysy käyttäjältä nimi, pituus metreinä ja paino kilon tarkkuudella.
Laske painoindeksi bmi muuttujaan seuraavasti:

bmi = paino / pituus ^ 2

Tulosta lopuksi:

Olli Opiskelija, pituutesi on 1,81 m ja painosi 104 kg
Painoindeksisi on siten 31,75
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string nimi;
            double pituus, paino, bmi;

            Console.Write("Anna nimi: ");
            nimi = Console.ReadLine();

            Console.Write("Anna pituus (metreinä, käytä pistettä): ");
            pituus = double.Parse(Console.ReadLine());

            Console.Write("Anna paino (kiloina): ");
            paino = double.Parse(Console.ReadLine());

            bmi = paino / (pituus*pituus);

            Console.WriteLine(nimi + ", pituutesi on " + pituus.ToString() + " m ja painosi " + paino.ToString() + " kg");
            Console.WriteLine("Painoindeksisi on siten " + bmi.ToString("f2"));
        }
    }
}