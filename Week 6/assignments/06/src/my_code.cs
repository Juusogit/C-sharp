using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tehtävänä on laskea pankkisiirtojen viitteistä tuttu tarkistenumero ja
tulostaa viitenumero ryhmiteltynä.

Alla on esimerkki laskemisesta. Lasketaan runko-osalle 12345 tarkistenumero:

          runko-osa     1     2     3     4     5
     painokertoimet     3     7     1     3     7
                        -------------------------
              tulot     3    14     3    12    35

näiden tulojen summa on 67

Siis oikealta alkaen kerrotaan numerot vuorollaan painoilla 
7, 3, 1, 7, 3, 1, 7, ... jne

Tarkistenumero on tulojen summa vähennettynä seuraavasta täydestä 
kymmenestä (paitsi jos summa on tasakymmeniä, on tarkiste nolla). 

Esimerkin tapauksessa siis tarkiste on 3. 

Alkuperäinen runko-osa ja tarkiste tulostetaan ruudulle näin: oikeanpuoleisimpaan 
ryhmään neljä + tarkiste, muihin viisi merkkiä ja ekaan niin monta kuin riittää

Ohjelman tulisi toimia seuraavasti:

Anna viitteen runko-osa : 325308000102798049011

Viitenumero : 32 53080 00102 79804 90117
*/


namespace Projekti
{
    class MyProgram
    {
        static void Main()
        {
            Console.Write("Anna viitteen runko-osa : ");
            string runko = Console.ReadLine();

            int[] painokertoimet = {7, 3, 1};
            int tarkiste = 0;

            for (int i = runko.Length - 1; i >= 0; i--)
            {
                int numero = int.Parse(runko[i].ToString());
                tarkiste += numero * painokertoimet[(runko.Length - 1 - i) %3] ;
            }

            tarkiste = (10 - (tarkiste % 10)) % 10;

            string ryhmitelty = "";

            for (int i = runko.Length - 1, j = 0; i >= 0; i--, j++)
            {
                ryhmitelty = runko[i] + ryhmitelty;

                if (j == 4 && i != 0)
                {
                    ryhmitelty = " " + ryhmitelty;
                    j = -1;
                }
            }

            Console.WriteLine("Viitenumero : " + ryhmitelty);
        }
    }
}