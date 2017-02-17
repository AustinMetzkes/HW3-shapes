using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace HW3_shapes
{ 


abstract class Shape

    {



        public Position Center { get; set; }



        public Shape(int x = 0, int y = 0) : this(new Position(x, y))

        {

        }



        public Shape(Position p)

        {

            Center = p;

        }



        public abstract double Area { get; }



        public abstract double Perimeter { get; }





    }

}
