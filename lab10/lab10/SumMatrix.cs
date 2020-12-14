using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class SumMatrix
    {
        float x=0;
        public void  Sum()
        {
            LoadMatrix m = new LoadMatrix();

            m.GenerateMatrix(10, 6);
            m.savematrix("Matrix1.txt");
            m.GenerateMatrix(8, 7);
            m.savematrix("Matrix2.txt");


            if (m.Matrix("Matrix1.txt"))
            {
               Console.WriteLine("Матрица 1");
               x+=m.find_matrix();

            }
            Console.WriteLine();
            if (m.Matrix("Matrix2.txt"))
            {
                Console.WriteLine("Матрица 2");
                x +=m.find_matrix();

            }
            Console.WriteLine("*************************************"+"\n"+$"Сумма четных столбцов двух матриц = {x.ToString()}");
        }
    }
}
