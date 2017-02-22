using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_shapes
{
    class Program
    {
        static void Main(string[] args)
            // a lot of the side lengths are the same, change them as you wish.
        {
            Console.WriteLine("Triangle test");
            TestTriangle();
            Console.WriteLine(" ");

            Console.WriteLine("Right Triangle test");
            TestRightTriangle();
            Console.WriteLine(" ");

            Console.WriteLine("Square test");
            TestSquare();
            Console.WriteLine(" ");

            Console.WriteLine("Rectangle test");
            TestRectangle();
            Console.WriteLine(" ");

            Console.WriteLine("Isosceles Trapezoid test");
            TestIsoscelesTrapezoid();
            Console.WriteLine(" ");

            Console.WriteLine("Circle test");
            TestCircle();
            Console.WriteLine(" ");

            Console.WriteLine("Regular Hexagon test");
            TestRegularHexagon();
            Console.WriteLine(" ");

            Console.ReadKey();

        }



        static void TestTriangle()

        {



            Triangle t = new Triangle(3, 4, 5, 0, 5);

            Console.WriteLine(t);
            Console.WriteLine("Area: " + t.Area);   

            Console.WriteLine("Perimeter: " + t.Perimeter);

           
            Console.WriteLine("Second shape test");
            

            Triangle t2 = new Triangle(4, 5, 6, 1, 3);

            Console.WriteLine(t2);

            Console.WriteLine("Area: " + t2.Area);

            Console.WriteLine("Perimeter: " + t2.Perimeter);

        }
        static void TestRightTriangle()

        {

            RightTriangle t = new RightTriangle(3, 4);

            Console.WriteLine(t);

            Console.WriteLine("Area: " + t.Area);


            Console.WriteLine("Perimeter: " + t.Perimeter);

            Console.WriteLine("Second shape test");

            RightTriangle t2 = new RightTriangle(4, 5);

            Console.WriteLine(t2);

            Console.WriteLine("Area: " + t2.Area);


            Console.WriteLine("Perimeter: " + t2.Perimeter);


        }
        static void TestSquare()

        {



            Square s = new Square(5, 2, 3);

            Console.WriteLine(s);
            Console.WriteLine("Area: " + s.Area);

            Console.WriteLine("Perimeter: " + s.Perimeter);

            Console.WriteLine("Second shape test");

            Square s2 = new Square(3, 5, 6);

            Console.WriteLine(s2);

            Console.WriteLine("Area: " + s2.Area);

            Console.WriteLine("Perimeter: " + s2.Perimeter);

        }
        static void TestRectangle()

        {



            Rectangle r = new Rectangle(3, 4, 0, 5);

            Console.WriteLine(r);
            Console.WriteLine("Area: " + r.Area);

            Console.WriteLine("Perimeter: " + r.Perimeter);

            Console.WriteLine("Second shape test");

            Rectangle r2 = new Rectangle(4, 5, 6);

            Console.WriteLine(r2);

            Console.WriteLine("Area: " + r2.Area);

            Console.WriteLine("Perimeter: " + r2.Perimeter);

        }
        static void TestIsoscelesTrapezoid()

        {



            IsoscelesTrapezoid i = new IsoscelesTrapezoid(3, 4, 5, 0, 5);

            Console.WriteLine(i);
            Console.WriteLine("Area: " + i.Area);

            Console.WriteLine("Perimeter: " + i.Perimeter);

            Console.WriteLine("Second shape test");

            IsoscelesTrapezoid i2 = new IsoscelesTrapezoid(4, 5, 6, 3, 5);

            Console.WriteLine(i2);

            Console.WriteLine("Area: " + i2.Area);

            Console.WriteLine("Perimeter: " + i2.Perimeter);

        }
        static void TestCircle()

        {



            Circle c = new Circle(3, 0, 5);

            Console.WriteLine(c);
            Console.WriteLine("Area: " + c.Area);

            Console.WriteLine("Perimeter: " + c.Perimeter);


            Console.WriteLine("Second shape test");

            Circle c2 = new Circle(4, 5, 6);

            Console.WriteLine(c2);

            Console.WriteLine("Area: " + c2.Area);

            Console.WriteLine("Perimeter: " + c2.Perimeter);

        }

        static void TestRegularHexagon()

        {



            RegularHexagon h = new RegularHexagon(3, 0, 5);

            Console.WriteLine(h);
            Console.WriteLine("Area: " + h.Area);

            Console.WriteLine("Perimeter: " + h.Perimeter);


            Console.WriteLine("Second shape test");

            RegularHexagon h2 = new RegularHexagon(4, 5, 6);

            Console.WriteLine(h2);

            Console.WriteLine("Area: " + h2.Area);

            Console.WriteLine("Perimeter: " + h2.Perimeter);

        }


    }

}