using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Shar
    {


        public Shar() {}
        public Shar (double pR)
        {
            R = pR;
        }
        public static Shar CreatefromtheFile()
        {
            double RR = Convert.ToDouble(Console.ReadLine());
            return new Shar(RR);
        }
        private double R;
       
        public double Load(double R)
        {
            return R;
        }
        public void Load()
        {
            R = Convert.ToDouble(Console.ReadLine());
        }

        private double Diam()
        {
            return 2 * R;
        }
        private double Volume()
        {
            return 1.0f * 4 / 3 * Math.PI * Math.Pow(R, 3);
        }
        private double Square()
        {
            return 4 * Math.PI * Math.Pow(R, 2);
        }
       
        public override string ToString()
        {
           

            return $"Объем шара = {Volume()}\nПлощадь шара = {Square()}\nДиаметр шара = {Diam()}";
        }

    }
}
