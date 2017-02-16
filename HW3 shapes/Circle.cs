using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public double Diameter { get; }

        public double Circumference { get; }
        //constructor (double radius, int x=0, int y=0)
    }

    public override double Area
    {
        get
        { 
            //pi * (r * r)
            //return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
    }
    public override double Perimeter

    {
        get
        {
            return Circumference;
        }
    }
    public Circle (double radius, int x = 0, int y=0)
    {
        Radius = radius;
    }
}
