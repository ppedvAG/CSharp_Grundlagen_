using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class PKW : FahrzeugBase
    {
        public PKW(string marke, string modell, int baujahr, double maxGeschw, string Farbe, int anzahlTueren, int anzahlRaeder) 
            : base(marke, modell, baujahr, maxGeschw, Farbe)
        {
            this.AnzahlRader = anzahlRaeder;
            this.AnzahlTueren = anzahlTueren;
        }

        public int AnzahlRader { get; set; }
        public int AnzahlTueren { get; set; }
    }

    public class BobbyCar : FahrzeugBase
    {
        public BobbyCar(string marke, string modell, int baujahr, double maxGeschw, string Farbe, int maxGewicht) 
            : base(marke, modell, baujahr, maxGeschw, Farbe)
        {
            this.MaxGeschwicht = maxGewicht;
        }

        public int MaxGeschwicht { get; set; }

        
    }
}
