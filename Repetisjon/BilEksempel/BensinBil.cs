using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetisjon.BilEksempel
{
    class BensinBil : Bil, IComparable<BensinBil>
    {
        public BensinBil(string Merke, string modell, int registreringsår, string registreringsnummer) 
            : base(Merke, modell, registreringsår, registreringsnummer)
        {
            BilType = "Bensinbil";
        }


        public int AntallLitereDrivstoff { get; set; } = 10;



        public bool Kjører()
        {
            AntallLitereDrivstoff--;
            if (AntallLitereDrivstoff <= 0)
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

            if (antallLitere + AntallLitereDrivstoff > 60)
            {
                Console.WriteLine("Du kan ikke fylle mer enn 60 liter");
                return false;
            }
            return true;
        }

        public int CompareTo(BensinBil? other)
        {
            if(other == null)
            {
                return -1;
            }
            if(Registreringsår < other.Registreringsår)
            {
                return -1;
            }
            if (Registreringsår > other.Registreringsår)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Merke} {Modell} {Registreringsår} {Registreringsnummer}";
        }
    }

}
