using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class SchiffBase : FahrzeugBase
    {
        public SchiffBase(string marke, string modell, int baujahr, double maxGeschw, string Farbe, double tiefgang)
            : base(marke, modell, baujahr, maxGeschw, Farbe )
        {
            this.Tiefgang = tiefgang;
        }

        public double Tiefgang { get; set; }
    }


    public class Yacht : SchiffBase
    {
        public Yacht(string marke, string modell, int baujahr, double maxGeschw, string Farbe, double tiefgang, bool pool) 
            : base(marke, modell, baujahr, maxGeschw, Farbe, tiefgang)
        {
            this.Pool = pool;
        }

        public bool Pool { get; set; }
    }

    public class Tretboot : SchiffBase
    {
        public Tretboot(string marke, string modell, int baujahr, double maxGeschw, string Farbe, double tiefgang, int anzahlPersonen) 
            : base(marke, modell, baujahr, maxGeschw, Farbe, tiefgang)
        {
            AnzahlPersonen = anzahlPersonen;
        }

        int AnzahlPersonen { get; set; }

    }
}
