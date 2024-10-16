using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Circle(int radie)
    {
        public int Radie = radie;

        public double GetArea(int radie)
        {
            double area = radie * radie * Math.PI;
            return area;
        }
    }
}
