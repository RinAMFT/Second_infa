using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnic
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double treug;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public bool IsValid()
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c)
                {
                    if (a + c > b)
                    {
                        if (b + c > a)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public double GetPerimeter()
        {
            Console.WriteLine(a + b + c);
            return a + b + c;

        }
        public void GetArea()
        {
            double s = GetPerimeter() / 2; 
            double areaSquared = s * (s - a) * (s - b) * (s - c);
            Console.WriteLine(Math.Sqrt(areaSquared));
        }
    }
}
