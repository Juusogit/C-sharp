using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, jolla voit laskea kuinka paljon saat työmarkkinatukea kuukaudessa 
jäädessäsi työttömäksi, kun et ole ollut niin pitkään töissä että saisit 
ansiosidonnaista työttömyyspäivärahaa. Työmarkkinatuen ehdot ja määrät ovat 
yksinkertaistettu malli oikeista työmarkkinatuen ehdoista ja ovat seuraavat: 
 
· Työmarkkinatuen määrä on 32,68 euroa/päivä ja sitä maksetaan viideltä päivältä viikossa.
· Lapset korottavat työmarkkinatukea seuraavasti: yksi lapsi 5,27 euroa/pv, kaksi lasta 7,74 euroa/ pv ja kolmesta tai useammasta yhteensä 9,98 e/pv
· Työllistymistä edistävä palvelu korottaa tukea 4,78 e/pv
· Jos tulot ylittävät 300 euroa, niin jokainen sen määrän ylittävä palkkana maksettu euro vähentää tukea 50 senttiä
· Jos asut vanhempiesi taloudessa tukea vähennetään 50% 

Ohjelmalla voi toistaa työmarkkinatuen laskemista niin monta kertaa kuin haluaa. 
Tuki lasketaan kuukaudelle, jossa on 4 viikkoa.

Alla on esimerkki ohjelman toiminnasta:  

Kuinka monta lasta sinulla on: 5
Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: 2
Kuinka paljon olet saanut palkkaa: 320
Asutko vanhempiesi luona (k/e): k
Saat työmarkkinatukea 426.38 euroa kuukaudessa
 
Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): e

HUOM! Kun käyttäjältä kysytään k/e, niin toteuta sen kysyminen siten, että käyttäjän
pitää painaa enteriä vastauksen jälkeen.
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main()
        {
            string ans = "k";
            while (ans == "k")
            {
                Console.Write("Kuinka monta lasta sinulla on: ");
                int lapset = int.Parse(Console.ReadLine());

                Console.Write("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: ");
                int tyokkari = int.Parse(Console.ReadLine());

                Console.Write("Kuinka paljon olet saanut palkkaa: ");
                double palkka = double.Parse(Console.ReadLine());

                Console.Write("Asutko vanhempiesi luona (k/e): ");
                string porukoilla = Console.ReadLine();

                double perusTuki = 32.68 * 5 * 4;
                double lapsilisa = 0;
                if (lapset == 1)
                    lapsilisa = 5.27 * 5 * 4;
                else if (lapset == 2)
                    lapsilisa = 7.74 * 5 * 4;
                else if (lapset >= 3)
                    lapsilisa = 9.98 * 5 * 4;

                double tyokkarikorv = 4.78 * tyokkari;

                double tuki = perusTuki + lapsilisa + tyokkarikorv;

                if (palkka > 300)
                {
                    double tulojenYlitys = palkka - 300;
                    double tukienVahennys = tulojenYlitys * 0.5;
                    tuki -= tukienVahennys;
                }

                if (porukoilla == "k")
                    tuki *= 0.5;

                Console.WriteLine("Saat työmarkkinatukea " + tuki.ToString("f2") + " euroa kuukaudessa");

                Console.Write("Haluatko laskea työmarkkinatuen uusilla tiedoilla (k/e): ");
                ans = Console.ReadLine();
            }
        }
    }
}