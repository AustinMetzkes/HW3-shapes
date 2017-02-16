using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Rectangle : Quadrilateral
    {
        public double Length

        {

            get

            {

                return Side1;

            }

            set

            {

                Side1 = value;

                Side3 = Side1;

            }
        }
        public double Width

        {

            get

            {

                return Side2;

            }

            set

            {

                Side2 = value;

                Side4 = Side2;

            }
        }
        public Rectangle(double l, double w) : base(l, w, 0)

        {

            Length = l;

            Width = w;

        }
    }
}
