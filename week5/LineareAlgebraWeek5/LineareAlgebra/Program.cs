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
            Matrix m = new Matrix(4, 4);
            bool inverseExists;
            m.inverse(4, out inverseExists);
        }
    }
}
