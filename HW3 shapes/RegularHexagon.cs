using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class RegularHexagon : Shape
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public double Side4 { get; set; }

        public double Side5 { get; set; }

        public double Side6 { get; set; }
        //side
        // constructor, (double side, int x=0, int y=0)
    }

    public override double Area
    {
        get
        {   
            return (((3*(Math.Sqrt(3)))/2)*(Side1 * Side1));
        }
    }

    public override double Perimeter

    {
        get
        {
            return (Side1 * 6);
        }
    }
}
