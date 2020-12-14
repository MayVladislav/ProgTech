using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Rocket:change,Draw
    {
        public Rocket(model type, int massa, int price)
        {
            Type = type;
            Massa = massa;
            Price = price;
        }


        public void Drawing()
        {
            Console.WriteLine
                (
            "_______╱╲_____\n" +
            "______╱▔▔╲_____\n" +
            "_____╱    ╲____\n" +
            "_____▏    ▕_____\n" +
            "_____▏    ▕_____\n" +
            "___╱▔▏    ▕▔╲___\n" +
            "___╱▔╲____╱▔╲___\n" 
                );
        }

        public void change_name(model pChange_name)
        {
            Type = pChange_name;
            if (Type == model.Falcon9)
            {
                Massa = 300;
                Price = 2000000;
            }
            else if (Type == model.Falcon9Heavy)
            {
                Massa = 400;
                Price = 3000000;
            }
            else if (Type == model.Soyuz)
            {
                Massa = 250;
                Price = 1000000;
            }
            else if (Type == model.Proton_K)
            {
                Massa = 280;
                Price = 2500000;
            }
            else
            {
                Massa = -1;
                Price = -1;
            }
        }

        public model Type;
        public int Massa, Price;

        public string info()
        {
            return $"Название = {Type}\nМаксимальная полезная нагрузка = {Massa} тонн\nСтоимость запуска =  {Price} тыс. $";
        }
    }
}
