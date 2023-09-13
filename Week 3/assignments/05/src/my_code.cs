using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä merkkejä, kunnes käyttäjä painaa enteriä. Isot kirjaimet tulostuvat pienenä 
ja pienet kirjaimet tulostuvat isona. Muut merkit eivät tulostu.

Riittää, että toimii kirjaimilla väliltä a-z ja A-Z.
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä merkkejä (lopetus painamalla Enter):");

            string syote = "";
            char merkki;

            do
            {
                merkki = Console.ReadKey().KeyChar;

                if (char.IsLetter(merkki))
                {
                    if (char.IsUpper(merkki))
                    {
                        merkki = char.ToLower(merkki);
                    }
                    else
                    {
                        merkki = char.ToUpper(merkki);
                    }

                    syote += merkki;
                }

            } while (merkki != '\r');

            Console.WriteLine();

            Console.WriteLine(syote);
        }
    }
}