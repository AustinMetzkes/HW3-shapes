﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Square : Rectangle
    {
        public double Side

        {

            get

            {

                return Side1;

            }

            set

            {

                Side1 = value;

                Side2 = Side1;

                Side3 = Side1;

                Side4 = Side1;


            }
        }
        public double l
        {
            get
            {
                return Side1;
            }
        }
        public double w
        {
            get
            {
                return Side2;
            }
        }

        public Square(double side, int x = 0, int y = 0) : base(side, side, x, y)
        {
            Side1 = side;
        }
        public override string ToString()
        {
            return $"Side: {Side1}; Center: {Center}";
        }
    }
}
