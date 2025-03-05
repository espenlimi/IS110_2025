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

            //Klasse, objekt osv..
            //string input = Console.ReadLine();
            //string[] inputArray = input.Split(",");

            //Bil minBilFraInput = new Bil(inputArray[0], inputArray[1], int.Parse(inputArray[2]), inputArray[3]);
            Bil minBil = new Bil("Volvo", "XC90", 2019, "AB12345");

            Bil minAndreBil = new Bil
            {
                Merke = "Volvo",
                Modell = "XC60",
                Registreringsnummer = "313",
                Registreringsår = 2020
            };
            Bil minTredjeBil = new Bil();
            minTredjeBil.Modell = "XC40";
            minTredjeBil.Merke = "Volvo";
            minTredjeBil.Registreringsår = 2021;
            minTredjeBil.Registreringsnummer = "123";

            //Løkker
            //For-løkke, while, foreach

            while (minBil.Kjører())
            {
                Console.WriteLine("Bilen kjører");
            }
            minBil.FyllDrivstoff(10);

            for (int i = 0; i < 5 && minAndreBil.Kjører(); i++)
            {
                //Første gang i løkken: i = 0, drivstoff = 9
                //Andre gang i løkken: i = 1, drivstoff = 8
                //Tredje gang i løkken: i = 2, drivstoff = 7
                Console.WriteLine("Den andre bilen kjører");
            }
            minAndreBil.FyllDrivstoff(5);

            Bil[] biler = new Bil[3];
            biler[0] = minBil;
            biler[1] = minAndreBil;
            biler[2] = minTredjeBil;



            //Løkker med array
            for (int i = 0; i < biler.Length; i++)
            {
                while (biler[i].Kjører())
                {
                    Console.WriteLine($"Bilen {biler[i].Merke} {biler[i].Modell} kjører");
                }
            }
            Fylldrivstoff(biler);
            foreach (Bil bil in biler)
            {
                while (bil.Kjører())
                {
                    Console.WriteLine($"Bilen {bil.Merke} {bil.Modell} kjører");
                }
            }

            List<Bil> bilListe = new List<Bil>(3);
            bilListe.Add(minBil);
            bilListe.Add(minAndreBil);
            bilListe.Add(minTredjeBil);


            Fylldrivstoff(biler);


            //Løkker med liste
            for (int i = 0; i < biler.Length; i++)
            {
                while (biler[i].Kjører())
                {
                    Console.WriteLine($"Bilen {biler[i].Merke} {biler[i].Modell} kjører");
                }
            }
            Fylldrivstoff(biler);
            foreach (Bil bil in biler)
            {
                while (bil.Kjører())
                {
                    Console.WriteLine($"Bilen {bil.Merke} {bil.Modell} kjører");
                }
            }

            static void Fylldrivstoff(Bil[] biler)
            {
                foreach (Bil bil in biler)
                {
                    bil.FyllDrivstoff(10);
                }
            }

            var sorterteBiler =
                from bil in bilListe
                orderby bil
                select new {BilVerdi = bil.Merke+bil.AntallLitereDrivstoff };

            foreach (var bil in sorterteBiler)
            {
                Console.WriteLine(bil);
            }

           // Bil[] bilerArray = LagBilSamling();

            var bilerArrayMedVar = LagBilSamling();
        }

        private List<Bil> LagBilSamling()
        {

            return new List<Bil>();
        }
    }
}
