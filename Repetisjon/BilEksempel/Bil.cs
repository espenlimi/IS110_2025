using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetisjon.BilEksempel
{
    class Bil
    {
        public string Merke { get; set; }
        public string Modell { get; set; }
        public int Registreringsår { get; set; }
        public string Registreringsnummer { get; set; }

        public Bil(string Merke, string modell, int registreringsår, string registreringsnummer)
        {
            this.Merke = Merke;
            Modell = modell;
            Registreringsår = registreringsår;
            Registreringsnummer = registreringsnummer;
        }

        protected string BilType { get; set; } = "Bil";

        public  string GetBilType()
        {
            return BilType;
        }
    }
}
