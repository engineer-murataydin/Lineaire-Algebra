using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek4
{
    class Matrix3D : Matrix
    {
        Matrix3D()
            : base(4, 4)
        { }

        public static Matrix Scale(double x, double y, double z)
        {
            Matrix3D scale = new Matrix3D();

            scale.set(1, 1, x);
            scale.set(2, 2, y);
            scale.set(3, 3, z);
            scale.set(4, 4, 1);

            return scale;
        }

        public static Matrix Translate(double x, double y, double z)
        {
            Matrix3D translate = new Matrix3D();

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
            Matrix3D rotate = new Matrix3D();
            double cos = 0;
            double sin = 0;
            rotate.set(1, 1, 1);
            rotate.set(2, 2, cos);
            rotate.set(3, 2, sin);
            rotate.set(2, 3, -sin);
            rotate.set(3, 3, cos);

            return rotate;
        }
        public static Matrix RotateOverY(double alpha)
        {
            Matrix3D rotate = new Matrix3D();
            double cos = 0;
            double sin = 0;
            rotate.set(1, 1, cos);
            rotate.set(1, 3, sin);
            rotate.set(2, 2, 1);
            rotate.set(3, 1, -sin);
            rotate.set(3, 3, cos);

            return rotate;
        }
        public static Matrix RotateOverZ(double alpha)
        {
            Matrix3D rotate = new Matrix3D();
            double cos = 0;
            double sin = 0;
            rotate.set(1, 1, cos);
            rotate.set(2, 1, sin);
            rotate.set(1, 2, -sin);
            rotate.set(2, 2, cos);
            rotate.set(3, 3, 1);

            return rotate;
        }
    }
}
