using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Lub
{
    internal class RovnStor : Triangle
    {
        public double Per { get; set; }
        public RovnStor(double per)
        {
            Per = per;

        }
        public  double Area()
        {
            return (Per * Per * Math.Sqrt(3)) / 4;
        }
        public  double Perimetr()
        {
            return Per * 3;
        }
        public  string Print()
        {
            return $"Площадь {Area():F2}," +
                $" периметр {Perimetr():F2}";
        }
    }
}