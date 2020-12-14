using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG  
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
 #endif

            Graf x = new Graf();

            x.Load();
            Console.WriteLine(x.ToString());

 #if !DEBUG 
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
 #else 
            Console.ReadKey();
 #endif
        }
        
    }
}
