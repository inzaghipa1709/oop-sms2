using System;
using System.Net;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\nAccessing Base Class :");

            Y y = new Y();
            int result = y.AccessMyMethodThenAccessBaseMethod();
            Console.WriteLine(result);

            Console.WriteLine("\nMixing :");

            int dd = result;
            ChildClass c = new ChildClass();
            Console.WriteLine(c.GetMethodOwnerName());

            //Console.WriteLine("\Shadowing :");

            //int dd = result;
            //ChildClass c = new ChildClass();
            //Console.WriteLine(c.GetMethodOwnerName());

            Console.WriteLine("\nStatic Poly :");

            StatPoly staticPoly = new StatPoly();
            int result1 = staticPoly.Add(1, 2, 3);
            Console.WriteLine(result1);
            int result2 = staticPoly.Add(1, 2);
            Console.WriteLine(result2);

            Console.WriteLine("\nDynamic Poly :");

            Drawing drawing;

            drawing = new Circle();
            drawing.Area(1);
            Console.WriteLine(drawing.Area(1));

            drawing = new Square();
            drawing.Area(2);
            Console.WriteLine(drawing.Area(2));
        }
    }
}