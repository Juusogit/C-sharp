using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, joka laskee mäkihyppääjän yhden kierroksen suorituspisteet. Ohjelma kysyy hypyn pituuden 
(liukuluku 0.5 metrin välein ja pituuden oltava > 0) sekä viiden arvostelutuomarin tyylipisteet (0-20 välillä 0.5 välein eli 
esim. 16.5 tai 17.0 tai 18.5). Vinkki. Jakojäännöksellä saa tutkittua onko puolen pisteen/metrin välein

Hyppääjän pisteet muodostuvat kaavasta.

pisteet = (hypyn pituus - kriittinen piste) * 1.8 + kolmen keskimmäisen tuomarin tyylipisteet + 60. 

Tyylipisteissä siis parhain ja huonoin pistemäärä tipahtaa pois.

Ohjelman hyppyrimäen kriittinen piste on 90 metrin kohdalla. Laita kriittinen piste vakioon KR_PISTE. 
Tulosta lopuksi hypyn pituus ja hypyn pisteet yhden desimaalin tarkkuudella seuraavalla tavalla.

PITUUS  : 115,5 m
PISTEET : 161,4

Käytä ohjelmassa funktioita (funktiot eivät saa palauttaa mitään ja kun käytät viittauksia, niin pitää
käyttää out-viittausta):

KysyHypynPituus
KysyTuomareidenPisteet
LaskeHypynPisteet
Tulosta

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
        public const double KR_PISTE = 90.0;

        public static void KysyHypynPituus(out double pituus)
        {
            pituus = 0;
            while (pituus <= 0)
            {
                Console.Write("Syötä hypyn pituus (metreinä): ");
                double.TryParse(Console.ReadLine(), out pituus);

                double desimaali = pituus - (int)pituus;
                if (desimaali != 0.5 && desimaali != 0)
                {
                    pituus = 0;
                }
            }
        }

        public static void KysyTuomareidenPisteet(out double[] pisteet)
        {
            pisteet = new double[5];

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write("Syötä tuomarin " + (i + 1) + " pisteet (0-20, 0.5 välein): ");
                } while (!double.TryParse(Console.ReadLine(), out pisteet[i]) || pisteet[i] < 0 || pisteet[i] > 20 || pisteet[i] % 0.5 != 0);
            }
        }

        public static double LaskeHypynPisteet(double pituus, double[] pisteet)
        {
            double summa = 0;
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double piste in pisteet)
            {
                summa += piste;

                if (piste < min)
                    min = piste;

                if (piste > max)
                    max = piste;
            }

            summa -= min + max;
            double pisteetKokonaisuudessaan = (pituus - KR_PISTE) * 1.8 + summa + 60;

            return Math.Round(pisteetKokonaisuudessaan, 1);
        }

        public static void Tulosta(double pituus, double pisteet)
        {
            Console.WriteLine("PITUUS  : " + pituus.ToString("f1") + " m");
            Console.WriteLine("PISTEET : " + pisteet.ToString("f1"));
        }

        public static void MyMain()
        {
            double pituus;
            KysyHypynPituus(out pituus);

            double[] tuomariPisteet;
            KysyTuomareidenPisteet(out tuomariPisteet);

            double hyppypisteet = LaskeHypynPisteet(pituus, tuomariPisteet);

            Tulosta(pituus, hyppypisteet);
        }
    }
}