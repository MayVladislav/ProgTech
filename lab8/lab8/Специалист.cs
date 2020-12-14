using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Специалист
    {
        public Специалист(string Ф, string И, string О)
        {
            Фамилия = Ф;
            Имя = И;
            Отчество = О;

        }



        string Фамилия, Имя, Отчество;

        public virtual string ФИО
        {
            get 
            {
                return Фамилия + " " + Имя + " " + Отчество;
            }
        }
    }
    class Программист:Специалист
    {
        public Программист(string Ф, string И, string О, ЯзыкиПрограммирования языкиП)
            : base(Ф,И,О)
        {
            ЯзыкПрограммирования = языкиП;
        }
        public ЯзыкиПрограммирования ЯзыкПрограммирования;


        public override string ФИО
        {
            get
            {
                return base.ФИО + " " + ЯзыкПрограммирования.ToString();
            }
        }
    }

    class Врач : Специалист
    {
        public Врач(string Ф, string И, string О, Специальности специальности)
            : base(Ф, И, О)
        {
            Специальность = специальности;
        }
        public Специальности Специальность;


        public override string ФИО
        {
            get
            {
                return base.ФИО + " " + Специальность.ToString();
            }
        }
    }

    class Летчик : Специалист
    {
        public Летчик(string Ф, string И, string О, Звания звания)
            : base(Ф, И, О)
        {
            Звание = звания;
        }
        public Звания Звание;



        public override string ФИО
        {
            get
            {
                return  Звание.ToString() + " "+ base.ФИО ;
            }
        }
    }
    public enum ЯзыкиПрограммирования 
    {
        Python,
        Pascal,
        Java,
        Kotlin


    }
    public enum Звания
    {
        Полковник,
        Майор,
        Лейтенант,
        Капитан
    }
    public enum Специальности
    {
        Терапевт,
        Хирург,
        Травматолог,
        ЛОР
    }
}
