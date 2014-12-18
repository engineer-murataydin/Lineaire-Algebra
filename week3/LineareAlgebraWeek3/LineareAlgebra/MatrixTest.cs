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
        { }

        public void scaleZero()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 1);
            test.set(2, 1, 0);
            test.set(3, 1, 1);

            Matrix expectedResult = test.Copy();
            Matrix result = Matrix3D.Scale(1, 1, 1) * test;

            if (expectedResult != result)
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is correct!");
            }
        }

        public void translateZero()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 1);
            test.set(2, 1, 0);
            test.set(3, 1, 1);

            Matrix result = Matrix3D.Translate(0, 0, 0) * test;

            Matrix3D test2 = new Matrix3D();
            Matrix3D expectedResult2 = new Matrix3D();
            expectedResult2.set(1, 1, 1);
            expectedResult2.set(2, 1, 2);
            expectedResult2.set(3, 1, 3);

            Matrix result2 = Matrix3D.Translate(1, 2, 3) * test2;

            if (expectedResult2 != result2)
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is correct!");
            }
        }

        public void RotateOverX()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 7);
            test.set(3, 1, 3);

            double length = matrixLength(test);

            Matrix result = Matrix3D.RotateOverX(2) * test;

            double length2 = matrixLength(result);

            if (test.get(1, 1) != result.get(1, 1) || length != length2)
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is correct!");
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

            if (test.get(2, 1) != result.get(2, 1) || length != length2)
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is correct!");
            }
        }

        public void RotateOverZ()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 7);
            test.set(3, 1, 3);

            double length = matrixLength(test);

            Matrix result = Matrix3D.RotateOverZ(2) * test;

            double length2 = matrixLength(result);

            if (test.get(3, 1) != result.get(3, 1) || length != length2)
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }
            else
            {
                Console.WriteLine("Het resultaat is correct!");
            }
        }

        public void rotateOne()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 4);
            test.set(2, 1, 7);
            test.set(3, 1, 3);

            double length = matrixLength(test);

            Matrix result = Matrix3D.Rotate(2, 2, 2, 2);

            double length2 = matrixLength(result);

            //if()
            //{

            //}
            //else
            //{

            //}
        }

        public void rotateTwo()
        {

        }

        public double matrixLength(Matrix m)
        {
            return Math.Sqrt(Math.Pow(m.get(1, 1), 2) + Math.Pow(m.get(2, 1), 2) + Math.Pow(m.get(3, 1), 2));
        }
    }
}
