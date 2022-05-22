using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Lub
{
    internal class Rovn : Triangle
    {
        public double Per { get; set; }
        public double Ugl { get; set; }
        public Rovn(double per, double ugl)
        {
            Per = per;
            Ugl = ugl;
        }
        public  double Area()
        {

            return ((Per + Per + Math.Sqrt((Per * Per) + (Per * Per) - 2 * Per * Per * Math.Cos(Ugl)) - Per + Per) / 2) * Per;
        }
        public  double Perimetr()
        {
            return (Per + Per + Math.Sqrt((Per * Per) + (Per * Per) - 2 * Per * Per * Math.Cos(Ugl)));
        }
        public  string Print()
        {
            return $"Площадь {Area()},\n" +
                $" периметр {Perimetr()}";
        }
    }
}
