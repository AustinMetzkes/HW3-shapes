﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    abstract class Quadrilateral : Shape
    {

        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public double Side4 { get; set; }




        public Quadrilateral(int x = 0, int y = 0) : base(x, y)

        {



        }

    }
}

