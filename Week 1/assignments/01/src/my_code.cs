/*
Esittele ja anna alkuarvot muuttujille, joihin pitäisi tallentaa seuraavat tiedot:

piin likiarvo
lähiosoite
henkilötunnus
nimesi ensimmäinen kirjain
lämpötila yhden desimaalin tarkkuudella

Tulosta arvot muuttujista allekkain käyttäen sekä Console.WriteLine(), että Console.Write()-komentoja.
Ohjelman pitää tulostaa seuraavat tiedot:

3.14159
Munkkikuja 3
121299A1234
S
-12.4
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double pii = 3.14159;
            string osoite = "Munkkikuja 3";
            string hetu = "121299A1234";
            char kirjain = 'S';
            float d = -12.4f;

            Console.Write(pii + "\n");
            Console.Write(osoite + "\n");
            Console.Write(hetu + "\n");
            Console.Write(kirjain + "\n");
            Console.Write(d + "\n");
        }
    }
}