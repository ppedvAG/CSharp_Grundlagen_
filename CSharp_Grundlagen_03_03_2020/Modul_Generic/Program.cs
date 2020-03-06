using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modul_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringListe = new List<string>();
            stringListe.Add("erstes element");
            stringListe.Add("zweites element");
            string ausgelesenerString = stringListe[0];

            Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();

            dictionary.Add(Guid.NewGuid(), "abc");
            dictionary.Add(Guid.NewGuid(), "bcd");
            dictionary.Add(Guid.NewGuid(), "cde");
            dictionary.Add(Guid.NewGuid(), "def");
            dictionary.Add(Guid.NewGuid(), "efg");

            foreach (KeyValuePair<Guid, string> item in dictionary)
            {
                //item.Key 
                //item.Value
            }
        }
    }
}
