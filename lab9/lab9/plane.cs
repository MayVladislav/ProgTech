using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class plane:change,Draw
    {

        public plane(model Pname, int speed, int altitude)
        {
            name = Pname;
            max_speed = speed;
            max_altitude = altitude;
            
        }

        public void change_name(model pChange_name)
        {
            name = pChange_name;
            if (name == model.A320)
            {
                max_speed = 720;
                max_altitude = 9000;
            }
            else if (name == model.A380)
            {
                max_speed = 820;
                max_altitude = 8000;
            }
            else if (name == model.Boeing747)
            {
                max_speed = 850;
                max_altitude = 10000;
            }
            else if (name == model.Boeing777)
            {
                max_speed = 1020;
                max_altitude = 11000;
            }
            else if (name == model.SJ100)
            {
                max_speed = 900;
                max_altitude = 15000;
            }
            else
            {
                max_speed = -1;
                max_altitude = -1;
            }

        }

       /* public void change_speed(int pChange_speed)
        {
            max_speed= pChange_speed;
        }

        public void change_altitude(int pChange_alt)
        {
            max_altitude= pChange_alt;
        }
       */

        public void Drawing()
        {
            Console.WriteLine
               ("__________________________$$$$_______________________\n" +
                "________________________$$$$$$$______________________\n" +
                "______________________$$_____$_______________________\n" +
                "_____________________$$$$$$$$________________________\n" +
                "____________________$______$_________________________\n" +
                "___________________$$$$$$$$__________________________\n" +
                "__________________$______$________________________$$_\n" +
                "_________________$______$________________________$$$_\n" +
                "________________$______$________________________$$$$_\n" +
                "_______________$______$________________________$$$$$_\n" +
                "_____$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_\n" +
                "__$$$_$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n" +
                "_$$$_$$$_$_$_$_$______$_$_$_$_$_$_$_$_$_$_$_$$$$$$$$$\n" +
                "$$$$$$$$$$$$$$$_$______$_$$$$$$$$$$$$$$$$$$$$$$$$$$$_\n" +
                "_$$$$$$$$$$$$$$$$$______$$$$$$$$$$$$$$$$$$$$$$$$$$$__\n" +
                "__________________$______$___________________________\n" +
                "___________________$$$$$$$$__________________________\n" +
                "____________________$______$_________________________\n" +
                "_____________________$$$$$$$$________________________\n" +
                "______________________$$_____$_______________________\n" +
                "________________________$$$$$$$______________________\n" +
                "__________________________$$$$_______________________\n");
        }

        public int max_speed, max_altitude;
        public model name;

        public string info()
        {
            return $"Название = {name}\nМаксимальная высота = {max_altitude} метров\nМаксимальная скорость =  {max_speed} км/ч";
        }

    }

    public enum model
        {
            Boeing747,
            Boeing777,
            A320,
            A380,
            SJ100,

            Falcon9,
            Falcon9Heavy,
            Soyuz,
            Proton_K

    }
}

