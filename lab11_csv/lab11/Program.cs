using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_21.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            StreamWriter new_out = new StreamWriter(@"lr_output.txt");
            Console.SetOut(new_out);
#endif

            List<Person> all = new List<Person>();
            
            try
            {
                String line = f_in.ReadLine();
                while((line = f_in.ReadLine()) != null)
                {
                    all.Add(Person.Create(line));
                }
                   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Всего пользователей: {0}", all.Count);
            /*foreach (var p in all)
            {
                Console.WriteLine(p);
            }
           */
                
            
            Console.WriteLine("*********Задача 1************");

            double counts = 0;
            int k = 0;
            for (int i = 0; i<all.Count; i++)
            {
                if (all[i].Plus - all[i].Minus > 0)
                {
                    k += 1;
                    counts+= Convert.ToDouble(all[i].Plus -all[i].Minus);
                }
                
            }
            Console.WriteLine($"Средний баланс среди положительных счетов = {counts/k}\n");

            Console.WriteLine("**********Задача 2**********");
            Console.WriteLine($"Количество счетов с отрицательным балансом = {all.Count - k}\n");
           
                        Console.WriteLine("**********Задача 3**********");
                        int lownalog = 0;
                        for (int i = 0; i < all.Count; i++)
                        {
                            if (all[i].Plus -all[i].Minus < all[i].Tax)
                            {
                                lownalog++;
                            }

                        }
                        Console.WriteLine($"Счетов, где баланса недостаточно для уплаты налага = {lownalog}\n");
 
                        Console.WriteLine("**********Задача 4**********");
                        double maxbalance = 0;
                        string Name = "";

                        for (int i = 0; i < all.Count; i++)
                        {
                            if (all[i].Plus - all[i].Minus > maxbalance)
                            {
                                maxbalance = all[i].Plus - all[i].Minus;
                                Name = $"{all[i].Fname} {all[i].Lname}"; 
                            }

                        }
                        Console.WriteLine($"Максимальный баланс = {maxbalance}, Имя владельца = {Name}");


#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}
