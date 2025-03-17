using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetisjon.BilEksempel
{
    class SemiTrailer : BensinBil
    {
        public SemiTrailer(string Merke, string modell, int registreringsår, string registreringsnummer) : base(Merke, modell, registreringsår, registreringsnummer)
        {
            BilType = "Semitrailer";
        }

    }
}
