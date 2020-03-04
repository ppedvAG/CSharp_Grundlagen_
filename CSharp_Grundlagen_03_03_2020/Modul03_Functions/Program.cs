using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul03_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 30;
            int zahl2 = 11;
            int ergebnis = Addieren(zahl1, zahl2);
            //Aufruf der Addiere(int,int)-Funktion (optinale Parameter werden auf ihren Default-Wert gesetzt)
            ergebnis = Addieren(5, 10);
            ergebnis = Addiere(12, 45, 78, 89);

            Console.WriteLine(ergebnis);
            Console.ReadKey();


            int differenz = 0;

            ergebnis = AddiereUndSubtrahiere(zahl1, zahl2, out differenz);

            int parseResult = 0;

            if (int.TryParse(ergebnis.ToString(), out parseResult))
            {
                // parseResult ist Valide
                // arbeite mit parseResult. 
            }
            else
                //Fehlerbehandlung

            Console.WriteLine(ergebnis);
            Console.WriteLine(differenz);
            Console.ReadKey();


            Console.WriteLine("Beispiel Nullable Variablen");
            int? multiplikator1 = null;
            int? mulitplikator2 = null;

            if (!multiplikator1.HasValue)
                multiplikator1 = 10;

            if (!mulitplikator2.HasValue)
                mulitplikator2 = 15;

            Console.ReadKey();
            
            int summe = 0;
            //Aufruf der Params-Funktion mit Übergabe eines Arrays, einer bleiebigen Anzahl von Ints und nichts
            summe = BildeSumme(new int[] { 2, 4, 5 });
            summe = BildeSumme(7, 8, 9, 45, 12, 741,7,34,45,23,3,234,234,22); //geht nicht ohne params
            summe = BildeSumme(); //geht nicht ohne params


        }

        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        public static int Addieren(int a, int b)
        {
            a = 15;
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiplikation(int? a, int? b)
        {
            if (!a.HasValue)
                throw new Exception();

            if (!b.HasValue)
                throw new ArgumentException();

            return a.Value * b.Value;
        }


        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b + c + d;
        }

        #region Methoden sind auch überlagerbar -> jede Methode mit gleichen Namen muss eine andere Signatur vorweisen
        public static double Addiere(double a, double b)
        {
            return a + b;
        }

        public static float Addiere(float a, float b)
        {
            return a + b;
        }
        #endregion

        /// <summary>
        /// Addieres the und subtrahiere. -> Schlechtes Beispiel
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="differenz">The differenz.</param>
        /// <returns></returns>
        public static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }

        public static int BildeSumme(params int[] summanden)
        {
            int summe = 0;
            foreach (int currentSummanden in summanden )
            {
                summe += currentSummanden;
            }

            return summe;
        }




    }
}
