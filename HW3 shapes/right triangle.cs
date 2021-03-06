﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace HW3_shapes

{

    class RightTriangle : Triangle

    {

        public double Base

        {

            get

            {

                return Side1;

            }

            set

            {

                Side1 = value;

                Side3 = Math.Sqrt(Base * Base + Height * Height);

            }

        }

        public double Height

        {

            get

            {

                return Side2;

            }

            set

            {

                Side2 = value;

                Side3 = Math.Sqrt(Base * Base + Height * Height);

            }

        }

        public double Hypotenuse

        {

            get { return Side3; }

        }



        public RightTriangle(double b, double h) : base(b, h, 0)

        {

            Base = b;

            Height = h;

        }



    }

}