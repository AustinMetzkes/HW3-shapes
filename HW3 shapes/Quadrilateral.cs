using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Quadrilateral : Shape
    {

        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public double Side4 { get; set; }

    }

    public override double Area

    {

        get

        {            

            return (Side1 * Side2);

        }
    }

                public override double Perimeter

    {

        get

        {

            return Side1 + Side2 + Side3 + Side4;

        }
    }

        public Quadrilateral (double side1, double side2, double side3, double side4, int x = 0, int y = 0)
    {
        Side1 = side1;

        Side2 = side2;

        Side3 = side3;

        Side4 = side4;
    }

    }

