using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Trapezoid : IsoscelesTrapezoid
    {
        public double Base1

        {

            get

            {

                return Base1;

            }

            set

            {

                Base1 = value;

                // fix to find the sides of the trapezoid
                

            }
        }
        public double Base2

        {

            get

            {

                return Base2;

            }

            set

            {

                Base2 = value;

                

            }
        }
        public double altitude

        {

            get

            {

                return Altitude;

            }

            set

            {

                Altitude = value;


            }
        }
    }
}
