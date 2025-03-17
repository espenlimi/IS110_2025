using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetisjon.BilEksempel
{
    class BilProgram
    {
        public void KjørProgram()
        {

            /*
             Forslag til repetisjon
            - Lage egne klasser og objekter (f.eks. en klasse for en bil, med constructor)
            - De tre løkkene
            - If-setninger
            - Metoder
            - Arrays
             */

            List<Bil> bilListe = new List<Bil>(4);
            bilListe.Add(new Elbil("Volvo", "EC40", 2025, "aasdasd"));
            bilListe.Add(new SemiTrailer("Scania", "R500", 2021, "asdasd"));
            bilListe.Add(new BensinBil("Toyota", "Corolla", 2019, "asdasd"));
            bilListe.Add(new Bil("Opel", "kadett", 1998, "asdasd"));

            foreach(Bil bil in bilListe)
            {
                Console.WriteLine($"{bil.GetType().Name} {bil.GetBilType()}");
            }

        }
    }
}