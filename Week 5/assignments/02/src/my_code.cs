using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Kysy käyttäjältä kuinka iso taulukko luodaan. Luo taulukko ja arvo siihen arvosanoja 
väliltä 0-5. Tutki kuinka moni sai hylätyn arvosanan eli arvosanan 0. 
Tulosta määrä näytölle seuraavalla tavalla:

Hylättyjä arvosanoja oli : 4 kpl

Käytä ohjelmassa seuraavia funktioita :

KysyKoko        (funktio ei palauta mitään, viittaukset out:lla)
LuoTaulukko     (funktio ei palauta mitään, viittaukset out:lla, parametrina ensin koko tieto, sitten taulukko)
ArvoArvosanat   (funktio ei palauta mitään)
TutkiHylatyt    (funktio palauttaa hylättyjen määrän)
Tulosta         (funktio ei palauta mitään)


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
        public static void KysyKoko(out int koko)
        {
            Console.Write("Syötä taulukon koko: ");
            koko = Convert.ToInt32(Console.ReadLine());
        }

        public static void LuoTaulukko(int koko, out int[] taulukko)
        {
            taulukko = new int[koko];
        }

        public static void ArvoArvosanat(int[] taulukko)
        {
            Random random = new Random();
            for (int i = 0; i < taulukko.Length; i++)
            {
                taulukko[i] = random.Next(6);
            }
        }

        public static int TutkiHylatyt(int[] taulukko)
        {
            int hylatyt = 0;
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] == 0)
                {
                    hylatyt++;
                }
            }
            return hylatyt;
        }

        public static void Tulosta(int hylatyt)
        {
            Console.WriteLine("Hylättyjä arvosanoja oli : " + hylatyt + " kpl");
        }

        public static void MyMain()
        {
            int koko;
            KysyKoko(out koko);

            int[] taulukko;
            LuoTaulukko(koko, out taulukko);

            ArvoArvosanat(taulukko);

            int hylatyt = TutkiHylatyt(taulukko);

            Tulosta(hylatyt);
        }
    }
}