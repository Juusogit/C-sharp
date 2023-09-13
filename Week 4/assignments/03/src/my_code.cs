using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä pitkähkö teksti string muuttujaan. Muuta kaikki kirjaimet isoiksi kirjaimiksi 
ja tulosta muutettu teksti. Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti. 
Poista kaikki välilyönnit ja tulosta teksti. Tulosta lopuksi kaikki merkit lopusta alkuun 
yhdellä välilyönnillä eroteltuna 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kerro lyhyt tarina");
            string teksti = Console.ReadLine();

            string isoK = teksti.ToUpper();
            Console.WriteLine(isoK);

            string aViha = isoK.Replace("A", "!");
            Console.WriteLine(aViha);

            string space = aViha.Replace(" ", "");
            Console.WriteLine(space);

            char[] merkit = space.ToCharArray();
            Array.Reverse(merkit);
            string kaannetty = string.Join(" ", merkit);
            Console.WriteLine(kaannetty);
        }
    }
}