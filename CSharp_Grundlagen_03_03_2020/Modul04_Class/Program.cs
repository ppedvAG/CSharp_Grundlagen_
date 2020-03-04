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
            Fahrzeug fahrzeug = new Fahrzeug();

            Fahrzeug fahrzeug2 = new Fahrzeug("VW", "Käfer", 1984, 110, "Gelb");


            string text = "                           Hallo ich bin ein Text und hier         kann vieles drin stehen";

            Console.WriteLine(text.Trim());

            Console.WriteLine(fahrzeug.ToString());
            Console.ReadKey();
        }
    }
}
