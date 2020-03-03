using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Erste Applikation
            Console.WriteLine("Beispiel  1 von ");
            Console.WriteLine("Hallo Welt");
            Console.ReadKey();
            #endregion

            System.Console.WriteLine("Explizierter WriteLine Befehl mit System");

            #region Variable and integer Types
            Console.Clear();
            Console.WriteLine("Beispiel 2 von ");
            int alter = 36;
            string name = "Kevin";

            Console.WriteLine($"Mein Alter beträgt {alter}");
            Console.WriteLine($"Mein Name ist {name}");
            Console.ReadKey();

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            long longVariable = 32342342342323;
            Console.WriteLine(longVariable);
            #endregion

            #region floating Types
            Console.Clear();
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            float floatVariable = 4.5f;
            float f = 3_000.5F;
            float ergebnis = floatVariable + f;

            decimal money = 4.4234m;
            
            //1.000.000
            decimal moneyB = 4_000_000.56m;
            #endregion


            //Camel Casing
            string firstNameOfTheFamilyName = string.Empty;
            char zeichen = 'e';
            //ungarische Notation
            string strFirstName = string.Empty;
            int intAlter = 32;

            #region Ausgabevarianten
            Console.Clear();
            Console.WriteLine("Beispiel 3 von ");
            string vorname = "Max";
            string nachname = "Mustermann";
            DateTime geburtsdatum = new DateTime(1988, 5, 10);
            string stadt = "Berlin";

            string Satz = "Ich bin " + alter + " Jahre alt und wohne in " + stadt + ".";
            Console.WriteLine("<--- Ausgabe: traditionell über Stringverknüpfung (+-Operator) --->");
            Console.WriteLine("Ich bin " + alter + " Jahre alt und wohne in " + stadt + ".");
            Console.ReadKey();

            //Index (Variablen werden durch Index-Platzhalter vertreten und später definiert)
            Console.WriteLine("{0} {1} wurde am {2} geboren", vorname, nachname, geburtsdatum);

            //$-Operator (Variablen werde direkt in {}-Klammern geschrieben
            Console.WriteLine($"{vorname} {nachname} wurde am {geburtsdatum} geboren");
            Console.ReadKey();

            #endregion


            #region string Escapezeichen / Pfadausgaben
            Console.Clear();
            Console.WriteLine("Beispiel 4 von ");

            //String-Formatierung mittels Escape-Sequenzen
            string text = $"Sehr geehrter, \n mein Name ist {vorname} {nachname} \t Viel Spass.";

            //Bsp für Pfadausgabe mittels Escape-Sequenzen 
            string dateiPfad = "C:\\Windows\\System";

            string relativerPfad = "/bin/Version1/start.exe";

            //Verbatim-String
            string dateiPfad1 = @"C:\Windows\System\n";
            #endregion

            #region Eingabe eines String in die Console 
            Console.Clear();
            Console.WriteLine("Beispiel 5 von ");
            Console.Write("Geben das Wort des Tages ein: ");
            vorname = Console.ReadLine(); // -> Readline = eingabe einer Zeichenkette + [Enter]
            Console.ReadKey();
            #endregion

            #region Eingabe eines Integers in eine Console
            Console.Clear();
            Console.WriteLine("Beispiel 6 von ");

            Console.Write("Geben Sie eine Zahl ein: ");
            int umgewandelteZahl = int.Parse(Console.ReadLine());
            Console.WriteLine($"Eingegebene Zahl ist {umgewandelteZahl}");
            Console.ReadKey();


            #endregion



            //Converter->Matrix->https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions

            #region Casting von float/double/decimal -> int/long/short
            Console.Clear();
            Console.WriteLine("Beispiel 7 von ");

            float kommazahl = 3.5f;
            int ergebnisA = (int)kommazahl;
            int ergebnisB = Convert.ToInt32(kommazahl);
            Console.WriteLine($"Rundungsergebnis mit explizietem casten: {ergebnisA}");
            Console.WriteLine($"Rundungsergebnis mit Convert.ToInt32(...): {ergebnisB}");
            Console.ReadKey();
            #endregion

            #region Casting von float/double/decimal -> int/long/short


            //int ergebnisC = int.Parse(kommazahl.ToString()); //Hier gibt es einen Fehler -> FormatException
            
            int ergebnisD;

            if (int.TryParse(kommazahl.ToString(), out ergebnisD))
            {
                // ergebnisD ist hier valide
                Console.WriteLine($"ErgebnisD ist valide -> {ergebnisD}");
            }
            else
            {
                Console.WriteLine("Es konnte nicht geparst werden -> Fehler");
            }



            #endregion

            #region int to string
            int neueZahl = 12345;
            Console.WriteLine(neueZahl.ToString());
            #endregion

            #region Zeichensatz 

            Console.OutputEncoding = Encoding.UTF8;
            char eurozeichen = '€';
            Console.WriteLine("Beispiel 7 von ");
            Console.WriteLine(eurozeichen);
            Console.ReadKey();

            int gebeMirDieKleinereZahlZurück  = Math.Min(5, 7);
            int gebeMirDieGrößereZahlZurüclk = Math.Max(56, 23);

          
            #endregion
        }
    }
}
