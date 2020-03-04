using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class Fahrzeug
    {
        private int baujahr;
        private string marke;
        private string modell;
        private double aktGeschwindigkeit;
        private double maxGeschwindigkeit;

        private string _farbe;


        // Auto Property -> Membervariable wird automatisch im Hintergrund angelegt. 
        public bool MotorLäuft { get; set; }
        
        public int Baujahr
        {
            get
            {
                //Logik
                return baujahr;
            }

            set
            {
                // Logik 
                if (value > 300)
                    baujahr = value;
                else
                    baujahr = 300;
            }
        }

        public string Marke 
        {
            get => marke;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    marke = value;
                else
                    marke = "undefinierte Marke";
            }
        }

        public string Modell { get => modell; set => modell = value; }
        public double AktGeschwindigkeit 
        { 
            get => aktGeschwindigkeit; 
            set => aktGeschwindigkeit = value; 
        }
        public double MaxGeschwindigkeit 
        { 
            get => maxGeschwindigkeit; 
            set => maxGeschwindigkeit = value; 
        }

        public string Tachoanzeige
        {
            get
            {
                return AktGeschwindigkeit.ToString() + " - " + MaxGeschwindigkeit.ToString();
            }
        }

        public bool MussFahrzeugZumTüv()
        {
            if (!DateTime.IsLeapYear(Baujahr))
                return false;

            return true;
        }

        public void StarteMotor()
        {
            MotorLäuft = true;
        }

        public void Beschleunigung(int a)
        {
            if (MotorLäuft==true)
            {
                if (AktGeschwindigkeit + a > MaxGeschwindigkeit)
                    AktGeschwindigkeit = MaxGeschwindigkeit;
                else if (AktGeschwindigkeit + a < 0)
                    AktGeschwindigkeit = 0;
                else
                    AktGeschwindigkeit += a;
            }
        }

        public void StoppeMotor()
        {
            MotorLäuft = false;
            AktGeschwindigkeit = 0;
        }
        
    }
}
