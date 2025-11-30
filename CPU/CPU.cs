using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU
{
    public class CPU
    {
        public string model;
        public double frequency;
        public int coreCount;
        public CPU(string model, double frequency, int coreCount)
        {
            this.model = model;
            this.frequency = frequency;
            this.coreCount = coreCount;
        }
        public double Performance
        {
            get
            {
                return frequency * coreCount;
            }
        }
        public void Overclock(double percentage)
        {
            if (percentage > 0)
            {
                this.frequency *= (1 + percentage);
                Console.WriteLine($"\nНовая частота: {this.frequency:F2} ГГц");
            }
            else
            {
                Console.WriteLine("Неверный процент разгона. Частота осталась прежней.");
            }
        }
    }
}
