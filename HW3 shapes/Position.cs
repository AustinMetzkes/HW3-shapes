using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    // struct
    struct Position

    {

        public int x { get; set; }

        public int y { get; set; }




        public Position(int x = 0, int y = 0)

        {

            this.x = x;

            this.y = y;

        }


        public override string ToString()

        {

            return $"({x}, {y})";

        }

    }