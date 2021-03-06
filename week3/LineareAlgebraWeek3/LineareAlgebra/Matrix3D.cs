﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek2
{
    class Matrix3D : Vector
    {
        public Matrix3D()
            : base(4)
        {
            set(4, 1, 1);
        }

        public static Matrix Scale(double x, double y, double z)
        {
            Matrix scale = new Matrix(4, 4);

            scale.set(1, 1, x);
            scale.set(2, 2, y);
            scale.set(3, 3, z);
            scale.set(4, 4, 1);

            return scale;
        }

        public static Matrix Translate(double x, double y, double z)
        {
            Matrix translate = new Matrix(4, 4);

            translate.set(1, 1, 1);
            translate.set(2, 2, 1);
            translate.set(3, 3, 1);
            translate.set(4, 4, 1);

            translate.set(1, 4, x);
            translate.set(2, 4, y);
            translate.set(3, 4, z);

            return translate;
        }

        public static Matrix RotateOverX(double alpha)
        {
            Matrix rotate = new Matrix(4, 4);
            double cos = Math.Cos(alpha);
            double sin = Math.Sin(alpha);
            rotate.set(1, 1, 1);
            rotate.set(2, 2, cos);
            rotate.set(3, 2, sin);
            rotate.set(2, 3, -sin);
            rotate.set(3, 3, cos);
            rotate.set(4, 4, 1);

            return rotate;
        }
        public static Matrix RotateOverY(double alpha)
        {
            Matrix rotate = new Matrix(4, 4);
            double cos = Math.Cos(alpha);
            double sin = Math.Sin(alpha);
            rotate.set(1, 1, cos);
            rotate.set(1, 3, sin);
            rotate.set(2, 2, 1);
            rotate.set(3, 1, -sin);
            rotate.set(3, 3, cos);
            rotate.set(4, 4, 1);

            return rotate;
        }
        public static Matrix RotateOverZ(double alpha)
        {
            Matrix rotate = new Matrix(4, 4);
            double cos = Math.Cos(alpha);
            double sin = Math.Sin(alpha);
            rotate.set(1, 1, cos);
            rotate.set(2, 1, sin);
            rotate.set(1, 2, -sin);
            rotate.set(2, 2, cos);
            rotate.set(3, 3, 1);
            rotate.set(4, 4, 1);

            return rotate;
        }

        public static Matrix Rotate(double alpha, double x, double y, double z)
        {
            Console.WriteLine("TODO fix Rotate in Matrix3D");

            double t1 = Math.Atan2(z, x);
            double t2 = Math.Atan2(y, Math.Sqrt(x * x + z * z));
            return RotateOverY(-t1) * RotateOverZ(-t2) * RotateOverX(alpha) * RotateOverZ(t2) * RotateOverY(t1);//TODO FIX!!
        }

        public static Matrix Rotate(double alpha, double x, double y, double z, double Mx, double My, double Mz)
        {
            return Translate(Mx, My, Mz) * Rotate(alpha, x, y, z) * Translate(-Mx, -My, -Mz);
        }
    }
}
