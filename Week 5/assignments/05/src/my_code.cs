using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Luo 7 alkioinen float-taulukko ja lue siihen käyttäjältä arvoja. Kun käyttäjä syöttää arvoa 
taulukkoon, niin ohjelma ei saa kaatua vaan väärä arvo on kysyttävä uudestaan. 
Lajittele taulukko ja tulosta taulukon minimi- ja maksimiarvot yhden desimaalin
tarkkuudella seuraavasti:

MIN : 12.3
MAX : 34.9


Käytä funktioita:

LuoTaulukko         : funktio palauttaa luodun taulukon
KysyArvotTaulukkoon : funktio saa parametrina taulukon
LajitteleTaulukko   : funktio saa parametrina taulukon
TulostaTiedot       : funktio saa parametrina taulukon

HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void MyMain()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta
*/
namespace Projekti
{
    class MyProgram
    {
        public static float[] LuoTaulukko()
        {
            float[] taulukko = new float[7];
            return taulukko;
        }

        public static void KysyArvotTaulukkoon(float[] taulukko)
        {
            for (int i = 0; i < taulukko.Length; i++)
            {
                bool validiArvo = false;
                while (!validiArvo)
                {
                    Console.Write("Syötä arvo taulukkoon yhden desimaalin tarkkuudella. " + i + ": ");
                    if (float.TryParse(Console.ReadLine(), out float arvo))
                    {
                        taulukko[i] = arvo;
                        validiArvo = true;
                    }
                    else
                    {
                        Console.WriteLine("Väärä arvo. Syötä uusi arvo.");
                    }
                }
            }
        }

        public static void LajitteleTaulukko(float[] taulukko)
        {
            Array.Sort(taulukko);
        }

        public static void TulostaTiedot(float[] taulukko)
        {
            Console.WriteLine("MIN : " + taulukko[0].ToString("f1"));
            Console.WriteLine("MAX : " + taulukko[taulukko.Length - 1].ToString("f1"));
        }

        public static void MyMain()
        {
            float[] taulukko = LuoTaulukko();
            KysyArvotTaulukkoon(taulukko);
            LajitteleTaulukko(taulukko);
            TulostaTiedot(taulukko);
        }
    }
}