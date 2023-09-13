using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele sellainen 2-ulottoinen taulukko, johon voit tallentaa maanantain ja perjantain välisenä aikana 
neljä mittaustulosta jokaiselta päivältä (mittaustulos on sademäärä milleinä). Lue käyttäjältä nämä 
mittaustulokset taulukkoon ja tulosta lopuksi jokaisen päivän mittaustulosten 
keskiarvo seuraavan esimerkin mukaisesti :

Maanantai   : 12.0 mm
Tiistai     : 0.0 mm
Keskiviikko : 1.9 mm
Torstai     : 22.8 mm
Perjantai   : 0.9 mm
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string[] paivat = { "Maanantai", "Tiistai", "Keskiviikko", "Torstai", "Perjantai" };
            double[,] sademaarat = new double[5, 4];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paivat[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Syötä sademäärä mittaus " + (j + 1) + ": ");
                    string input = Console.ReadLine();
                    double sademaara;
                    while (!double.TryParse(input, out sademaara))
                    {
                        Console.Write("Virhe. Syötä uudelleen: ");
                        input = Console.ReadLine();
                    }
                    sademaarat[i, j] = sademaara;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                double summa = 0;
                for (int j = 0; j < 4; j++)
                {
                    summa += sademaarat[i, j];
                }
                double keskiarvo = summa / 4;
                Console.WriteLine(paivat[i].PadRight(12) + ": " + keskiarvo.ToString("f1") + " mm");
            }
        }
    }
}