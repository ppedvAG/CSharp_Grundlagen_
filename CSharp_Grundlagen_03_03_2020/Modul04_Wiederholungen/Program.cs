using Modul04_Wiederholungen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Wiederholungen
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    #region Vererbung
    /// <summary>
    /// Basisklasse
    /// </summary>
    public class Konto
    {
        public decimal Kontostand { get; private set; }

        internal string Kontoinhaber { get; set; }

        protected DateTime KontoPin { get; set; }

        public Konto (decimal konto)
        {
            Kontostand = konto;
        }
    }
    #endregion
}



namespace IrgendEinAndererNamespace
{
    //Abgeleitete Klasse von Konto
    public class Sparbuch : Konto
    {
        public decimal Zins { get; set; }


        //Sparbuch - Kontruktor ->
        //Base ist der Aufruf von Konto-Konstruktor
        public Sparbuch(decimal kontostand, decimal zins)
            : base(kontostand)
        {
            Zins = zins;
        }


        public decimal BerechnerZins(int Tage)
        {
            return Kontostand * 1.2m * Tage;
        }

        public decimal BerechnerZins(short Monat)
        {
            return Kontostand * 1.2m * Monat;
        }
    }

    public class GiroKonto : Konto
    {
        public decimal Gebühren { get; set; }

        public GiroKonto(decimal kontostand, decimal gebühr)
             : base(kontostand)
        {
            this.Gebühren = gebühr;
        }
    }

    public class GiroGiroKonto : GiroKonto
    {
        public GiroGiroKonto(decimal kontostand, decimal gebühr)
             : base(kontostand, gebühr)
        {
            this.Gebühren = gebühr;
        }
    }

   
}

