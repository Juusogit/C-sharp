using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
tee ohjelma, joka tulostaa ensin tiedon siitä, kuinka monta parametria Main-funktioon tuli seuraavalla tavalla.

parametreja tuli 2 kpl

Lisäksi jos ensimmäisen parametri oli "opettaja" niin tulosta "koita saada opiskelijat oppimaan", 
jos se taas oli "opiskelija", niin tulosta "koita opiskella ahkerasti". Jos se oli jotain muuta, 
niin tulosta "nyt en hiffannut"
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            int pm = args.Length;
            Console.WriteLine("parametreja tuli " + pm + " kpl");

            if (pm > 0)
            {
                string p = args[0];

                if (p == "opiskelija")
                {
                    Console.WriteLine("koita opiskella ahkerasti");
                }
                else if (p == "opettaja")
                {
                    Console.WriteLine("koita saada opiskelijat oppimaan");
                }
                else
                {
                    Console.WriteLine("nyt en hiffannut");
                }
            }
        }
    }
}