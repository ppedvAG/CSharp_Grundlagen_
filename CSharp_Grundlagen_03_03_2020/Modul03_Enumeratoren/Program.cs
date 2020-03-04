using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modul03_Enumeratoren
{
    enum Wochentag { Montag=1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }

    [Flags]
    public enum DinnerItems
    {
        None = 0,
        Entree = 1,
        Appetizer = 2,
        Side = 4,
        Dessert = 8,
        Beverage = 16,
        BarBeverage = 32
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Punkt bei Kommzahlen 
            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }


            Console.ReadKey();
            DinnerItems myOrder = DinnerItems.Appetizer | DinnerItems.Entree |
                           DinnerItems.Beverage | DinnerItems.Dessert;


            DinnerItems flagValue = DinnerItems.Entree | DinnerItems.Beverage;

            Console.WriteLine("{0} includes {1}: {2}",
                              myOrder, flagValue, myOrder.HasFlag(flagValue));

            //BitMask
            //https://docs.microsoft.com/de-de/dotnet/api/system.enum.hasflag?view=netframework-4.8

            //System.Environment.Exit(0);

            #region switch Sample
            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert

            Wochentag heute = Wochentag.Freitag;


            switch (heute)
            {
                case Wochentag.Montag:
                    Console.WriteLine("beliebtester Tag der Woche");
                    break;

                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. 
                //In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Nicht überarbeiten!");
                    break;
                case Wochentag.Freitag:
                    Console.WriteLine("Bald ist Wochenende!");
                    break;
                default:
                    Console.WriteLine("Endlich Wochenende");
                    break;
            }

            //Advanced Beispiel
            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            int a = 11;

            switch (a)
            {
                case 5:
                    Console.WriteLine("Irgendwas");
                    break;
                //a wird in b eingelegt (zu überprüfende Variable wir für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int b when b > 10:
                    Console.WriteLine("a ist größer als 10");
                    break;
                default:
                    break;
            }



            Console.ReadKey();
            #endregion
        }
    }
}
