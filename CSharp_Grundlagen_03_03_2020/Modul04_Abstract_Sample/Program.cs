using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Abstract_Sample
{
    public abstract class Shape
    {
        public Shape()
        {

        }

        public abstract decimal Area();

        public string Versionsausgabe ()
        {
            return "Version 1.0";
        }

        private void test()
        {

        }
    }

    public class Quatrat : Shape
    {
        int seitenLänge = 0;

        Quatrat(int seitenlänge)
        {
            seitenLänge = seitenlänge;
        }

        public override decimal Area()
        {
            return seitenLänge * seitenLänge;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
