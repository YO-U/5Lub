using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Lub
{
    internal class Pramoug : Triangle
    {
        public double StorPer { get; set; }
        public double StorVtor { get; set; }

        public Pramoug(double per, double vtor)
        {
            StorPer = per;
            StorVtor = vtor;

        }
        public  double Area()   
        {
            return (StorPer * StorVtor) / 2;
        }
        public  double Perimetr()
        {
            return StorPer + StorVtor + Math.Sqrt((StorPer * StorPer) + (StorVtor * StorVtor) - 2 * StorVtor * StorPer * Math.Cos(90));
        }
        public  string Print()
        {
            return $"Площадь {Area():F2},\n" +
                $" периметр {Perimetr():F2}";
        }
    }
}
