using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coren_iz_proizved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Число 1: ");
            //double chislo1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Число 2: ");
            //double chislo2 = Convert.ToDouble(Console.ReadLine());

            Class1 res = new Class1(1, 2);
            res.Output();
            Console.ReadKey();
        }
    }
}
