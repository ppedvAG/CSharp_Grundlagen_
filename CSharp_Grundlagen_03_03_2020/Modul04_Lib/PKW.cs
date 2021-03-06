﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class PKW : FahrzeugBase, IFahrlizenz
    {
        public PKW(string marke, string modell, int baujahr, double maxGeschw, string Farbe, int anzahlTueren, int anzahlRaeder) 
            : base(marke, modell, baujahr, maxGeschw, Farbe)
        {
            this.AnzahlRader = anzahlRaeder;
            this.AnzahlTueren = anzahlTueren;
        }

        public int AnzahlRader { get; set; }
        public int AnzahlTueren { get; set; }

        public int Altergrenz()
        {
            return 17;
        }

       

        public bool DarfIchBenutzen(int alter)
        {
            if (alter < 17)
                return false;

            return true;
        }
    }

    public class BobbyCar : FahrzeugBase, ICloneable
    {
        public BobbyCar()
        {

        }

        public BobbyCar(string marke, string modell, int baujahr, double maxGeschw, string Farbe, int maxGewicht) 
            : base(marke, modell, baujahr, maxGeschw, Farbe)
        {
            this.MaxGeschwicht = maxGewicht;
        }


        public int MaxGeschwicht { get; set; }

        public object Clone()
        {
            BobbyCar bobbyCar = new BobbyCar();
            bobbyCar.Modell = this.Modell;
            bobbyCar.Marke = this.Marke;
            bobbyCar.MaxGeschwicht = this.MaxGeschwicht;
            bobbyCar.AktGeschwindigkeit = this.AktGeschwindigkeit;
            bobbyCar.Farbe = this.Farbe;
            bobbyCar.MotorLäuft = this.MotorLäuft;
            bobbyCar.Baujahr = this.Baujahr;


            return bobbyCar;
        }
    }
}
