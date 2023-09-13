using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8 ja kirjoita ne "datat.txt" tiedostoon allekkain. 
Älä käytä taulukkoa tässä vaiheessa.

Sen jälkeen luo 40 alkioinen double-taulukko ja lue 
arvot tiedostosta taulukkoon. Tämän jälkeen tulosta taulukon lukujen 
summa, keskiarvo, minimiarvo ja maksimiarvo seuraavalla tavalla

SUMMA : 143.2
KA    : 3.6
MIN   : 1.4
MAX   : 5.7

Käytä funktioita:

ArvoJaTallennaTiedostoon
LueTiedostosta
TulostaTiedot


HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta

HUOM 3!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon tai luet sieltä, niin
StreamWriter ja StreamReader muuttujien esittelyt pitää olla näin:

StreamWriter sw = new StreamWriter(Path("datat.txt"));
StreamReader sr = new StreamReader(Path("datat.txt"));
*/
namespace Projekti
{
    public class MyProgram

    {
        public static void MyMain()
        {
            ArvoJaTallennaTiedostoon();

            double[] taulukko = LueTiedostosta();

            TulostaTiedot(taulukko);
        }

        public static void ArvoJaTallennaTiedostoon()
        {
            Random random = new Random();

            StreamWriter sw = new StreamWriter(Path("datat.txt"));

            for (int i = 0; i < 40; i++)
            {
                double luku = random.NextDouble() * (5.8 - 1.4) + 1.4;
                sw.WriteLine(luku);
            }

            sw.Close();
        }

        public static double[] LueTiedostosta()
        {
            StreamReader sr = new StreamReader(Path("datat.txt"));
            double[] taulukko = new double[40];
            int index = 0;

            string rivi;
            while ((rivi = sr.ReadLine()) != null)
            {
                double luku = double.Parse(rivi);
                taulukko[index] = luku;
                index++;
            }

            sr.Close();

            return taulukko;
        }

        public static void TulostaTiedot(double[] taulukko)
        {
            double summa = 0;
            double min = taulukko[0];
            double max = taulukko[0];

            foreach (double luku in taulukko)
            {
                summa += luku;
                if (luku < min)
                {
                    min = luku;
                }
                if (luku > max)
                {
                    max = luku;
                }
            }

            double keskiarvo = summa / taulukko.Length;

            Console.WriteLine("SUMMA : " + summa.ToString("f1"));
            Console.WriteLine("KA    : " + keskiarvo.ToString("f1"));
            Console.WriteLine("MIN   : " + min.ToString("f1"));
            Console.WriteLine("MAX   : " + max.ToString("f1"));
        }
    }
}