using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Специалист[] mas = new Специалист[4];
            mas[0] = new Программист("Иванов", "Иван", "Петрович", ЯзыкиПрограммирования.Java);
            mas[1] = new Врач("Сергеев", "Петр", "Алексеевич", Специальности.Травматолог);
            mas[2] = new Летчик("Дмитриев", "Евгений", "Петрович", Звания.Капитан);
            mas[3] = new Специалист("Дмитриев", "Евгений", "Петрович");
            

            for (int i = 0; i<mas.Length; i++)
            {
                Console.WriteLine(mas[i].GetType().Name);
                Console.WriteLine(mas[i].ФИО);
            }
            Console.ReadKey();
        }
    }
}
