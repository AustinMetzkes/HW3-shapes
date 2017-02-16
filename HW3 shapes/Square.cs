using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Square : Quadrilateral
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
    }
}
