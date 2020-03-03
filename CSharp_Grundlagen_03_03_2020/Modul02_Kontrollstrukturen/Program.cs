using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul02_Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 30;

            #region Sample1 - if statement

            if (a > b)
            {
                Console.WriteLine("a ist größer als b");
            }
            else if (a < b)
            {
                Console.WriteLine("b ist größer als a");
            }
            else
            {
                Console.WriteLine("a und b sind gleich groß");
            }
            #endregion

            #region if - shortcut

            // a==b ? -> Bedienung
            // A = B  -> True Block
            // A != B -> False Block

            string ergebnis = (a == b) ? "A = B" : "A != B";
            #endregion

            #region While-Schleife

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a < b)
            {
                a++;

                if (a == 29)
                {
                    Console.WriteLine("Die Variable a hat den Wert 29 erreicht.");

                    //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                    break;
                }
            }

            #endregion

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            #region do-while Schleife
            do
            {
                a *= 2;

                continue;
                //Console.WriteLine("Wird niemals ausgeführt");

            } while (a < 100);


            #endregion

            #region for-Statement

            for (int i = 0; i <100; i++)
            {
                Console.WriteLine($"i ist gerade {i}.");
            }

            //Bsp einer For-Schleife von 1-1000 mit einer Verdoppelung des Index nach jedem Durchlauf
            for (int i = 1; i <= 1000; i *= 2)
            {
                Console.WriteLine(i);
            }

            //Bsp für eine rückwärtslaufende Schleife von 10-1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region Beispiel Programm

            // Schreiben in eine Textdatei
            StreamWriter sw = new StreamWriter("zahlen.txt");

            for (int i = 0; i < 100; i++)
            {
                sw.WriteLine(i);
            }
            sw.Close();
            Console.ReadKey();

            // Lesen aus einer Textdatei
            StreamReader sr = new StreamReader("zahlen.txt");
            int summe = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                summe += int.Parse(line);
            }
            sr.Close();


            Console.WriteLine($"Summer ist: {summe}");

            Console.WriteLine("Ende Beispiel StreamWriter / StreamReader");
            Console.ReadKey();
            #endregion

            #region do-while
            Console.WriteLine("3.) do while");
            do
            {
                Console.WriteLine(DateTime.Now);
            } while (DateTime.Now.Second < 30);
            Console.ReadKey();
            #endregion


            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. 
            ///Die Größe des Arrays muss bei der Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.

            //feste Arrayzuordnung
            int[] zahlenArray = new int[5];
            zahlenArray[0] = 1;
            zahlenArray[1] = 2;
            zahlenArray[2] = 3;
            zahlenArray[3] = 4;
            zahlenArray[4] = 5;
            //zahlenArray[5] = 6; -> OutOfRangeException 

            //Arraygröße wird anhand der Elementen - Menge bestimmt
            int[] zahlenArray2 = { 5, 6, 12, 23, 65, 34, 25, 28, 44, 2, 3, 222 };

            //Ausgabe oder Durchlauf eines Arrays  VARIANTE 1
            for (int i = 0; i < zahlenArray.Length; i++)
            {
                Console.WriteLine(zahlenArray[i]);
            }

            //Variante 2
            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (int item in zahlenArray)
            {
                Console.WriteLine(item);
            }


        }
    }
}
