using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetisjon.BilEksempel
{
    class Elbil :Bil
    {
        public Elbil(string Merke, string modell, int registreringsår, string registreringsnummer) : base(Merke, modell, registreringsår, registreringsnummer)
        {
            BilType = "Elbil";
        }

       
    }
}
