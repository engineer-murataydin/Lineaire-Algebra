﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineareAlgebraWeek2
{
    class Vector : Matrix
    {
        public Vector(int m)
            : base(m, 1)
        {

        }

        public void set(int m, double value)
        {
            base.set(m, 1, value);
        }

        public double get(int m)
        {
            return base.get(m, 1);
        }
    }
}
