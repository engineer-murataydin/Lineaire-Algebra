using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek2
{
    class Matrix
    {
        double[][] matrix;
        public int M { get; private set; }
        public int N { get; private set; }

        public Matrix(int m, int n)
        {
            M = m;
            N = n;

            matrix = new double[M][];

            for (int i = 0; i < m; i++)
            {
                matrix[i] = new double[N];
            }
        }


        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.N != b.M)
            {
                throw new Exception("Matrix a's width (" + a.N + ") is not equal to b's height (" + b.M + ")");
            }
            Matrix multiply = new Matrix(a.M, b.N);
            for (int m = 1; m <= multiply.M; m++)
            {
                for (int n = 1; n <= multiply.N; n++)
                {
                    multiply.matrix[m - 1][n - 1] = multiplyArray(a.getRow(m), b.getCol(n));
                }
            }
            return multiply;
        }

        private static double multiplyArray(double[] row, double[] col)
        {
            double result = 0;
            for (int i = 0; i < row.Length; i++)
            {
                result += row[i] * col[i];
            }
            return result;
        }

        public double[] getCol(int n)
        {
            double[] col = new double[M];
            for (int i = 0; i < M; i++)
            {
                col[i] = matrix[i][n - 1];
            }
            return col;
        }

        public double[] getRow(int m)
        {
            return matrix[m - 1];
        }

        public double get(int m, int n)
        {
            return matrix[m - 1][n - 1];
        }

        public void set(int m, int n, double value)
        {
            matrix[m - 1][n - 1] = value;
        }

        public static Matrix scale(double velocity)
        {
            Matrix scale = new Matrix(2, 2);

            scale.set(1, 1, 1 + velocity / 200);
            scale.set(2, 2, 1 - velocity / 400);

            return scale;
        }

        public Matrix inverse(int no, out bool inverseExists)
        {
            inverseExists = false;
            int[,] a;
            int tnum;
            tnum = no;
            a = new int[tnum, tnum];
            int rowCount = a.GetUpperBound(0) + 1;
            string exists = "Inverse Matrix bestaat!";
            string notExists = "Inverse Matrix bestaat niet!";

            Console.WriteLine("Voer de matrix-waarden in: \n");
            for (int i = 0; i < tnum; i++)
            {
                for (int j = 0; j < tnum; j++)
                {
                    Console.Write("M[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Weergave van de waarden in de Matrix: \n");
            for (int i = 0; i < tnum; i++)
            {
                for (int j = 0; j < tnum; j++)
                {
                    if (a == null || a.Length != rowCount * rowCount)
                    {
                        throw new ArgumentException("Het algoritme moet worden voorzien van een (nx n+1) matrix!");
                    }
                    if(rowCount < 1)
                    {
                        throw new ArgumentException("De matrix moet tenminste één rij hebben!");
                    }

                    Console.Write("{0:F2}\t", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < tnum; i++)
            {
                int temp = a[i, i];

                for (int j = 0; j < tnum; j++)
                {
                    if(temp != 0) 
                    {
                        a[i, j] = a[i, j] / temp;
                        inverseExists = true;
                    }
                    else
                    {
                        inverseExists = false;
                    }
                }

                for (int k = 0; k < tnum; k++)
                {
                    temp = a[k, i];
                    if (i != k)
                    {
                        for (int j = 0; j < tnum; j++)
                        {
                            a[k, j] = a[k, j] - (temp * a[i, j]);
                        }
                    }
                }
            }
            Console.WriteLine("\n");
            if (inverseExists == true)
            {
                Console.WriteLine("Matrix opgelost: " + exists + "\n");
            }
            else
            {
                Console.WriteLine("Matrix opgelost: " + notExists + "\n");
            }
            for (int i = 0; i < tnum; i++)
            {
                for (int j = 0; j < tnum; j++)
                {
                    Console.Write("{0:F2}\t", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            return this;
        }
    }
}
