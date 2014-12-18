using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek2
{
    class Test
    {
        public Test()
        { }

        public void scaleZero()
        {
            Matrix3D test = new Matrix3D();
            test.set(1, 1, 1);
            test.set(1, 2, 0);
            test.set(1, 3, 1);
            test.set(2, 1, 0);
            test.set(2, 2, 1);
            test.set(2, 3, 0);
            test.set(3, 1, 1);
            test.set(3, 2, 0);
            test.set(3, 3, 1);

            Matrix3D expectedResult = test.Copy();

            Matrix result = test * Matrix3D.Scale(1, 1, 1);


        }
    }
}
