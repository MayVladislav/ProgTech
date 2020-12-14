using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Person
    {
        public string ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Balance { get; set; }
        public double Nalog { get; set; }

        public static Person Create(String line)
        {
            Person p = new Person();
            String[] e = line.Split(',');
            p.ID = e[0].Trim();
            p.Fname = e[1].Trim();
            p.Lname = e[2].Trim();
            p.Balance = Convert.ToDouble(e[3].Trim());
            p.Nalog = Convert.ToDouble(e[4].Trim());

            return p;
        }
    }
}
