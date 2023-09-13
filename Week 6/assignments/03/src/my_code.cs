using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Lue käyttäjältä teksti string tyyppiseen muuttujaan. Muuta koko teksti pieniksi kirjaimiksi 
ja kirjoita tiedostoon "kirjaimet.txt" allekkain joka toinen kirjain alkaen ensimmäisestä.

Esimerkiksi jos alkuperäinen teksti oli "TiiSTaI", niin se muutetaan "tiistai"
ja kirjoitetaan tiedostoon alla olevalla tavalla (HUOM! ei tyhjiä rivejä)

t
i
t
i

HUOM 1!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon, niin
StreamWriter muuttujan esittely pitää olla näin:

StreamWriter sw = new StreamWriter(Path("kirjaimet.txt"));
*/
namespace Projekti
{
    public class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        public static void Main(string[] args)
        {
            Console.Write("Syötä teksti: ");
            string teksti = Console.ReadLine();

            string pienetKirjaimet = teksti.ToLower();

            TallennaKirjaimet(pienetKirjaimet);
        }

        public static void TallennaKirjaimet(string teksti)
        {
            StreamWriter sw = new StreamWriter(Path("kirjaimet.txt"));

            for (int i = 0; i < teksti.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sw.WriteLine(teksti[i]);
                }
            }

            sw.Close();
        }
    }
}