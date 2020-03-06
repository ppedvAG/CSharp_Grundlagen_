
using Modul04_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Polymorphie
{
    class Program
    {
        static void Main(string[] args) 
        {
        
            List<string> strListe1 = new List<string>();
            IList<string> strListe2 = new List<string>();

            Garage garage = new Garage();

            try
            {
                BobbyCar bobbyCar = new BobbyCar("Lalelu", "Turboschnuller 2.0", 2020, 3, "Rot", 50);
                PKW pkw = new PKW("VW", "Passat", 1992, 120, "Blau", 4, 4);
                PKW pkw1 = new PKW("Ferrari", "Rote Göttin", 2001, 320, "Rot", 2, 4);
                Yacht yacht = new Yacht("Gib'Sea", "Ver 1.1", 1982, 10, "hellblau", 2.1, true);
                Yacht yacht1 = new Yacht("Wester", "Nautilus1", 1999, 12, "gelb", 3.1, false);
                Tretboot tretboot = new Tretboot("Opas Best Boats", "SimpleBoat 1.0", 2010, 2, "Blau", 0.3, 2);
                Tretboot tretboot1 = new Tretboot("Omas Best Boats", "SimpleBoat 2.0", 2010, 2, "Geld", 0.5, 2);
                Tretboot tretboot2 = new Tretboot("Titanic Best Boats", "SimpleBoat 3.0", 2010, 2, "Orange", 0.6, 1);
                Jet jet = new Jet("Airbus", "X-Wing", 2055, 800, "Schwarz", 15.6, 36000, 0, 2, 2.8);
                Jet jet1 = new Jet("Airbus", "Millenium Falke", 3001, 1800, "Grau", 15.6, 36000, 0, 2, 2.8);
                Propeller propeller = new Propeller("Fugger", "Albatros", 1915, 40, "Rot", 6.4, 4000, 0, 1, 1200);

            
                garage.Einparken(bobbyCar);
                garage.Einparken(pkw);
                garage.Einparken(pkw1);
                garage.Einparken(yacht);
                garage.Einparken(yacht1);
                garage.Einparken(tretboot);
                garage.Einparken(tretboot1);
                garage.Einparken(tretboot2);
                garage.Einparken(jet);
                garage.Einparken(jet1);
                garage.Einparken(propeller);

                bobbyCar.Baujahr = 1800;

                //Referenztypen, können im Nachgang noch den Inhalt einer Liste bearbeiten. Siehe am Beispiel BobbyCar
                BobbyCar clonedBobbyCar = (BobbyCar)bobbyCar.Clone();
                clonedBobbyCar.Baujahr = 1300;
                garage.Einparken(clonedBobbyCar);

                garage.DisplayInventar();

            }
            catch (FahrzeugMaxException ex)
            {

            }



            

            
        }
    }
}
