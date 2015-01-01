using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek4
{
    class Product
    {
        public Product()
        { }

        public double inproduct(Vector a, Vector b)
        {
            double result = 0;

            for (int i = 1; i <= a.getRows(); i++)
            {
                result += a.get(i, 1) * b.get(i, 1);
            }

            return result;
        }

        public Vector uitproduct(Vector a, Vector b)
        {
            Vector v = new Vector(a.getRows());

            v.set(1, 1, (a.get(2, 1) * b.get(3, 1)) - (a.get(3, 1) * b.get(2, 1)));

            v.set(2, 1, (a.get(3, 1) * b.get(1, 1)) - (a.get(1, 1) * b.get(3, 1)));

            v.set(3, 1, (a.get(1, 1) * b.get(2, 1)) - (a.get(2, 1) * b.get(1, 1)));

            return v;
        }

        public void toVector(int p, int q, int r, int s)
        {
            Vector v1, v2, v3;
            v1 = new Vector(1);
            v2 = new Vector(2);
            v3 = new Vector(3);

            if (p != 0)
            {
                v1.set(s / p, 0, 0);
                v2.set(-q, p, 0);
                v3.set(-r, 0, p);
            }
            else if (q != 0)
            {
                v1.set(0, s / q, 0);
                v2.set(q, 0, 0);
                v3.set(0, -r, q);
            }
            else if (r != 0)
            {
                v1.set(0, 0, s / r);
                v2.set(1, 0, 0);
                v3.set(0, 1, 0);
            }
        }
    }
}
