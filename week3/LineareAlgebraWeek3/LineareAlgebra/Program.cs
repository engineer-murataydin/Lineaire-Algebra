using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 3);
            Matrix matrix2 = new Matrix(3, 3);
            Matrix matrix3 = new Matrix(3, 3);

            matrix1.set(0, 0, 1);
            matrix1.set(1, 1, 1);
            matrix1.set(0, 2, 25);
            matrix1.set(1, 2, 50);
            matrix1.set(2, 2, 1);

            matrix2.set(0, 0, 0.80);
            matrix2.set(0, 1, -0.60);
            matrix2.set(1, 0, 0.60);
            matrix2.set(1, 1, 0.80);
            matrix2.set(2, 2, 1);

            matrix3.set(0, 0, 1);
            matrix3.set(1, 1, 1);
            matrix3.set(0, 2, -25);
            matrix3.set(1, 2, -50);
            matrix3.set(2, 2, 1);

            for (int m = 0; m < matrix1.M; m++)
            {
                for (int n = 0; n < matrix1.N; n++)
                {
                    Console.Write(matrix1.get(m, n) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int m = 0; m < matrix2.M; m++)
            {
                for (int n = 0; n < matrix2.N; n++)
                {
                    Console.Write(matrix2.get(m, n) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int m = 0; m < matrix3.M; m++)
            {
                for (int n = 0; n < matrix3.N; n++)
                {
                    Console.Write(matrix3.get(m, n) + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("__________*");

            try
            {
                Matrix matrix4 = matrix1 * matrix2 * matrix3;

                for (int m = 0; m < matrix4.M; m++)
                {
                    for (int n = 0; n < matrix4.N; n++)
                    {
                        Console.Write(matrix4.get(m, n) + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
