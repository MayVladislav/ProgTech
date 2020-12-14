using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Graf
    {
        private double a, b, sum, z;
        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            sum = Math.Pow(b, 2) / 2 - Math.Pow(a, 2) / 2;
            z = b - a;
            return $"Плащадь равна: {sum.ToString()}\nРасстояние от а до b = {z.ToString()} ";
        }
    }
}
