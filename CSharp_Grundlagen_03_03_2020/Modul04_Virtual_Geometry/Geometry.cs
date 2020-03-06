using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Virtual_Geometry
{

    //https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/virtual
    public class Shape
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) 
            : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * x * x;
        }

        public override string ToString()
        {
           return " Das habe ich noch dazu geschrieben";
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) 
            : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) 
            : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }

    public class Quatrat : Shape
    {
        public Quatrat (int a)
            :base (a,a)
        {
        }

        //Quatrat ruf implziet die Basis - Methode Shape.Area auf
    }


    public class Rechteck : Shape
    {
        public Rechteck (int a, int b)
            :base (a, b)
        {
        }

        public override double Area()
        {
            ////Rechteck ruf expliziet die Basis - Methode Shape.Area auf
            return base.Area();
        }
    }
}
