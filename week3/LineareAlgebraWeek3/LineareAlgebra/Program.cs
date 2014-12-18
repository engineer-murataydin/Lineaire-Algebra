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
            MatrixTest matrix_test =  new MatrixTest();

            // Test Methods
            Console.WriteLine("Opgave 2 -> Opgave a -> Schalen: \n");
            matrix_test.scaleZero();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Transleren: \n");
            matrix_test.translateZero();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Rotatie over de x-as: \n");
            matrix_test.RotateOverX();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Rotatie over de y-as: \n");
            matrix_test.RotateOverY();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave a -> Rotatie over de z-as: \n");
            matrix_test.RotateOverZ();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave b -> Rotatie 1: \n");
            matrix_test.rotateOne();
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Opgave 2 -> Opgave c -> Rotatie 2: \n");
            matrix_test.rotateTwo();
            Console.WriteLine("-----------------------------------\n");

            Console.ReadLine();
        }
    }
}
