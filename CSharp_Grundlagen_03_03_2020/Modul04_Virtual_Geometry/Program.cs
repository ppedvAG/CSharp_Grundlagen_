using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Virtual_Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            Circle c = new Circle(r);
            Sphere s = new Sphere(r);
            Cylinder l = new Cylinder(r, h);
            Quatrat q = new Quatrat(5);
            Rechteck re = new Rechteck(6, 7);
            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
            Console.WriteLine("Area of Square   = {0:F2}", q.Area());
            Console.WriteLine("Area of Rec   = {0:F2}", re.Area());


            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
