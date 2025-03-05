using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetisjon.BilEksempel
{
    class Bil
    {
        //Denne lages automatisk dersom ingen constructor er definert
        public Bil()
        {
            
        }
        public Bil(string Merke, string modell, int registreringsår, string registreringsnummer)
        {
            this.Merke = Merke;
            Modell = modell;
            Registreringsår = registreringsår;
            Registreringsnummer = registreringsnummer;
        }
    
        public string Merke { get;  set; }
        public string Modell { get; set; }
        public int Registreringsår { get; set; }
        public string Registreringsnummer { get; set; }
        public int AntallLitereDrivstoff { get; set; } = 10;

        public bool Kjører()
        {
            AntallLitereDrivstoff--;
            if(AntallLitereDrivstoff <= 0)
            {
                Console.WriteLine("Bilen er tom for drivstoff");
                return false;
            }
            return true;
        }

        public void FyllDrivstoff(int antallLitere)
        {
            bool fyllingerGyldig = FyllingErGyldig(antallLitere);
            if (fyllingerGyldig)
            {
                Console.WriteLine("Fyller drivstoff");
                AntallLitereDrivstoff += antallLitere;
            }
        }

        private bool FyllingErGyldig(int antallLitere)
        {
            if (antallLitere < 0)
            {
                Console.WriteLine("Du kan ikke fylle negativt antall liter");
                return false;
            }
     
            if(antallLitere + AntallLitereDrivstoff > 60)
            {
                Console.WriteLine("Du kan ikke fylle mer enn 60 liter");
                return false;
            }
            return true;
        }




    }
}
