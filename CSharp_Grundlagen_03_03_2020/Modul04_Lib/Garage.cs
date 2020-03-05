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

    }
}
