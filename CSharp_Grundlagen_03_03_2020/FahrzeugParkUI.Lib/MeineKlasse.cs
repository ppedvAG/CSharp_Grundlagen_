using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrzeugParkUI.Lib
{
    public class MeineKlasse
    {
        public int GebeEineZahlZurueck(string stringEingabe)
        {
            try
            {
                int retValue = int.Parse(stringEingabe);

                return retValue;
            }
            catch (FormatException ex)
            {
                // Info     
                // StackTrace:  ist der Ort an dem der Fehler entstanden ist
                // Message:     Fehlermeldung
                // Schreibe Fehlermeldung, die aus dem .NET Framework kommt in eine Log -> ex.Message + ex.StackTrace

                //Alternative ex.ToString();
                SchreibeInLogdatei(ex.StackTrace);

                throw new Exception("Bitte geben Sie eine Zahl ein");
            }
        }

        public void SchreibeInLogdatei(string logEintrag)
        {
            // Schreibe in Logdatei
        }

    }
}
