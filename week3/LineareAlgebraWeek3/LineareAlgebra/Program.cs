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
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 1);
            test.set(1, 2, 1);
            test.set(1, 3, 1);
            test.set(2, 1, 1);
            test.set(2, 2, 1);
            test.set(2, 3, 1);
            test.set(3, 1, 1);
            test.set(3, 2, 1);
            test.set(3, 3, 1);

            try
            {
                //Matrix scale = test * Matrix3D.Scale(1, 2, 3);
                Matrix scale = test * Matrix3D.Scale(0, 0, 5);

                for (int m = 1; m <= scale.M; m++)
                {
                    for (int n = 1; n <= scale.N; n++)
                    {
                        Console.Write(scale.get(m, n) + " ");
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
