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
        public string Email { get; set; }
        public double Plus { get; set; }
        public double Minus { get; set; }
        public long Credit_card { get; set; }
        public double Tax { get; set; }


       /* public override string ToString()
        {
            String s = string.Format(
                "**************************\n" +
                "ID:{0}, Имя: {1}, Фамилия: {2}, E-mail: {3}, \n"+
                "Пол.Баланс: {4}, Отр.Баланс {5}, Налоги: {6}",
                ID,Fname,Lname, TrueMail(Email), Plus,Minus,Credit_card,Tax);
            return s;
        }
       */

        public static Person Create(String line)
        {
            Person p = new Person();
            String[] e = line.Split(',');
            p.ID = e[0].Trim();
            p.Fname = e[1].Trim();
            p.Lname = e[2].Trim();
            p.Email = e[3].Trim();
            p.Plus = Convert.ToDouble(e[4].TrimStart('$').Replace('.',','));
            p.Minus = Convert.ToDouble(e[5].TrimStart('$').Replace('.', ','));
            p.Credit_card = Convert.ToInt64(e[6].Trim());
            p.Tax = Convert.ToDouble(e[5].TrimStart('$').Replace('.', ','));

            return p;
        }
        private static string TrueMail(string Email)
                {
            if (Email == "") 
                return "Нет почты";
            else 
                return Email;
                }
    }       
}
