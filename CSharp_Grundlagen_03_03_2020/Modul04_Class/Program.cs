using Modul04_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            FahrzeugBase fahrzeug2 = new FahrzeugBase("VW", "Käfer", 1984, 110, "Gelb");

            Console.WriteLine(FahrzeugBase.KmhTOMph(100));
            Console.ReadKey();



            //string meinString = "Hallo " + " liebe " + "Teilnehmer " + " jetzt " + " ist " + "gleicht Feierabend";

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hallo ");
            //sb.Append(" liebe ");
            //sb.Append(" usw....");

            //Console.WriteLine(sb.ToString());
        }
    }
}
