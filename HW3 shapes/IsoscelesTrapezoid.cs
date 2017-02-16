using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class IsoscelesTrapezoid : Shape
    {
        public double Base1 { get; set; }

        public double Base2 { get; set; }

        public double Altitude { get; set; }

    }

    public override double Area

    {

        get

        {
            
            return (((Base1 + Base2)/2) * Altitude);

        }
    }

    public override double Perimeter

    {

        get

        {
            //figure out perimeter
            return Side1 + Side2 + Side3 + Side4;

        }
    }
    public IsoscelesTrapezoid(double base1, double base2, double altitude, int x = 0, int y = 0)
    {
        Base1 = base1;

        Base2 = base2;

        Altitude = altitude;
        
    }
}
