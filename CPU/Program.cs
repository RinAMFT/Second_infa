using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPU myCpu = new CPU("Intel Core i7-13700K", 3.40, 16);
            myCpu.Overclock(0.15);
            Console.WriteLine($"Новая производительность (Performance): {myCpu.Performance:F2}");
            Console.ReadKey();
        }
    }
}
