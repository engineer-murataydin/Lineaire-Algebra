using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek2
{
    class MatrixTest
    {
        public MatrixTest()
        {  // Test Methods
            Console.WriteLine("Opgave 2 -> Opgave a -> Schalen: \n");
            scaleZero();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Transleren: \n");
            translateZero();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Rotatie over de x-as: \n");
            RotateOverX();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Rotatie over de y-as: \n");
            RotateOverY();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Rotatie over de z-as: \n");
            RotateOverZ();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave b -> Rotatie 1: \n");
            rotateOne();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave c -> Rotatie 2: \n");
            rotateTwo();
            Console.WriteLine("-----------------------------------\n");
        }

        public void scaleZero()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 1);
            test.set(2, 1, 0);
            test.set(3, 1, 1);

            Matrix expectedResult = test.Copy();
            Matrix result = Matrix3D.Scale(1, 1, 1) * test;
            Matrix expectedResult2 = new Matrix3D();
            Matrix result2 = Matrix3D.Scale(0, 0, 0) * test;

            if (expectedResult == result && expectedResult2 == result2)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public void translateZero()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 1);
            test.set(2, 1, 0);
            test.set(3, 1, 1);

            Matrix result = Matrix3D.Translate(1, 2, 3) * test;
            Matrix3D expectedResult = new Matrix3D();
            expectedResult.set(1, 1, 2);
            expectedResult.set(2, 1, 2);
            expectedResult.set(3, 1, 4);


            Matrix3D test2 = test.Copy();
            Matrix3D expectedResult2 = test2.Copy();


            Matrix result2 = Matrix3D.Translate(0, 0, 0) * test2;

            if (expectedResult2 == result2 && expectedResult == result)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public void RotateOverX()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 7);
            test.set(3, 1, 3);

            double length = matrixLength(test);

            Matrix result = Matrix3D.RotateOverX(4) * test;

            double length2 = matrixLength(result);

            if (test.get(1, 1) == result.get(1, 1) && length == length2)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public void RotateOverY()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 7);
            test.set(3, 1, 3);

            double length = matrixLength(test);

            Matrix result = Matrix3D.RotateOverY(2) * test;

            double length2 = matrixLength(result);

            if (test.get(2, 1) == result.get(2, 1) && length == length2)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public void RotateOverZ()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 7);
            test.set(3, 1, 3);

            double length = matrixLength(test);

            Matrix result = Matrix3D.RotateOverZ(3) * test;

            double length2 = matrixLength(result);

            if (test.get(3, 1) == result.get(3, 1) && length == length2)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public void rotateOne()
        {
            double x = 2;
            double y = x;
            double z = y;
            double a = 1;

            Matrix3D test = new Matrix3D();
            test.set(1, 1, a * x);
            test.set(2, 1, a * y);
            test.set(3, 1, a * z);

            double length = matrixLength(test);

            Matrix expectedResult = test.Copy();

            Matrix result = Matrix3D.Rotate(2, x, y, z) * test;

            result.print();
            expectedResult.print();

            double length2 = matrixLength(result);

            if (expectedResult == result && length == length2)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public void rotateTwo()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 4);
            test.set(3, 1, 4);

            double length = Math.Sqrt(Math.Pow(test.get(1, 1) - 1, 2) + Math.Pow(test.get(2, 1) - 1, 2) + Math.Pow(test.get(3, 1) - 1, 2));

            Matrix expectedResult = test.Copy();

            Matrix result = Matrix3D.Rotate(2, 2, 2, 2, 1, 1, 1) * test;

            double length2 = Math.Sqrt(Math.Pow(result.get(1, 1) - 1, 2) + Math.Pow(result.get(2, 1) - 1, 2) + Math.Pow(result.get(3, 1) - 1, 2));

            expectedResult.print();
            result.print();

            if (expectedResult == result && length == length2)
            {
                Console.WriteLine("Het resultaat is correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
        }

        public double matrixLength(Matrix m)
        {
            return Math.Sqrt(Math.Pow(m.get(1, 1), 2) + Math.Pow(m.get(2, 1), 2) + Math.Pow(m.get(3, 1), 2));
        }
    }
}
