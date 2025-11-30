using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle treug = new Triangle(3, 4, 5);
            treug.IsValid();
            treug.GetArea();
            Console.ReadKey();
        }
    }
}
