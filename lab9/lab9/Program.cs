using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane = new plane(model.A320,1700,30000);
            plane.Drawing();
            plane.change_name(model.SJ100);
            plane.change_name(model.Boeing777);
            Console.WriteLine(plane.info());
            Console.WriteLine("*****************\n\n\n");
            var rocket = new Rocket(model.Falcon9Heavy,100,1000000);
            rocket.change_name(model.Proton_K);
            rocket.Drawing();
            Console.WriteLine(rocket.info());

            Console.ReadKey();
         
        }
    }
}
