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
        public Rectangle(double l, double w, int x = 0, int y = 0) : base(x, y)

        {
            Side1 = l;
            Side2 = w;
        }
        public override double Area
        {
            get
            {
                return (Length * Width);
            }
        }
        public override double Perimeter
        {
            get
            {
                return (Side1 * 4);
            }
        }
        public override string ToString()
        {
            return $"Sides: {Side1}, {Side2}; Center: {Center}";
        }
    }

}
