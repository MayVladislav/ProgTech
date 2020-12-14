using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class LoadMatrix
    {     private int m, n;
          private float[,] matrix; 
        public Boolean Matrix(string pFilename)
        {
            if (File.Exists(pFilename))
            {
                try
                {
                    TextReader tr = File.OpenText(pFilename);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    matrix = new float[m, n];
                    string line;
                    string[] substring;
                    for (int i = 0; i<m; i++)
                    { 
                        for (int j = 0; j < n; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' },3);
                            matrix[i, j] = Convert.ToSingle(substring[2]);
                        }
                    }
                    tr.Close();
                    return true;

                }
                catch
                {
                    return false;
                }
               
            }
            return false;
        } 

        public float find_matrix()
        {
            float sum=0;
            if (matrix.Length > 0)
            {
                for (int i=0; i<m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j % 2 == 0) 
                        {
                            sum += matrix[i, j];
                        }
                        Console.Write(matrix[i, j].ToString() + " ");
                    }
                 Console.WriteLine();
                }

            }
            return sum;
        }

        public void GenerateMatrix(int M, int N)
        {
            m = M;
            n = N;
            Random r = new Random(DateTime.Now.Millisecond);
            matrix = new float[M, N];

            for (int i =0; i<M;i++)
                for (int j =0; j<N; j++)
                {
                    matrix[i, j] = (float)r.Next(1000);
                }
        }

        public void savematrix(string pFileName)
        {
            if (matrix.Length > 0)
            {
                if (File.Exists(pFileName))
                {
                    File.Delete(pFileName);
                }
                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();


                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + matrix[i, j].ToString());


                tw.Close();
            }
        }
        
    }
} 
