using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class Garage
    {
        private List<FahrzeugBase> fahrzeugListe;

        public Garage ()
        {
            fahrzeugListe = new List<FahrzeugBase>();
        }

        public void Einparken(FahrzeugBase fahrzeug)
        {
            fahrzeugListe.Add(fahrzeug);
        }

        public void DisplayInventar()
        {
            ConsoleColor bColor = Console.BackgroundColor;
            ConsoleColor fColor = Console.ForegroundColor;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Algemeine Zählung, Gruppenbasiert
            int shipCounter = 0;
            int plansCounter = 0;
            int automobile = 0;

            //Detail Zählung
            int pkwCounter = 0;
            int bobyCarCounter = 0;
            int jetCounter = 0;
            int propellerCunter = 0;
            int yachtCounter = 0;
            int tretbootCounter = 0;

            Console.WriteLine("Inventarliste:");

            foreach (FahrzeugBase currentFahrzeug in this.fahrzeugListe)
            {

                if (currentFahrzeug is SchiffBase)
                {
                    shipCounter++;
                }
                    

                if (currentFahrzeug is Yacht)
                {
                    yachtCounter++;
                }
                    

                if (currentFahrzeug is Tretboot)
                    tretbootCounter++;


                if (currentFahrzeug is Jet)
                    jetCounter++;

                if (currentFahrzeug is Propeller)
                    propellerCunter++;

                if (currentFahrzeug is FlugzeugBase)
                    plansCounter++;

                // Fahrzeuge
                if (currentFahrzeug is BobbyCar)
                    bobyCarCounter++;

                if (currentFahrzeug is PKW)
                    pkwCounter++;

                if (currentFahrzeug is FahrzeugBase)
                    automobile++;
            }



            Console.WriteLine("Fahrzeuge Insgesamt: " + automobile);
            Console.WriteLine("");
            Console.WriteLine("\t\n BobyCar: " + yachtCounter);
            Console.WriteLine("\t PKW: " + pkwCounter);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Flugzeuge Insgesamt: " + plansCounter);
            Console.WriteLine("\t Propeller: " + propellerCunter);
            Console.WriteLine("\t Jet: " + jetCounter);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Schiffe Insgesamt: " + shipCounter);
            Console.WriteLine("\t Yacht: " + propellerCunter);
            Console.WriteLine("\t Tretboot: " + tretbootCounter);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("[Press any Key]");
            Console.ReadKey();

            Console.BackgroundColor = bColor;
            Console.ForegroundColor = fColor;
        }

    }
}
