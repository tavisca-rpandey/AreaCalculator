using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10, 15);
            Circle c1 = new Circle(10);
            Square sq1 = new Square(10.32);
            Triangle t1 = new Triangle(5, 4, 7);

            r1.ShowArea();
            c1.ShowArea();
            sq1.ShowArea();
            t1.ShowArea();

            Console.ReadLine();
        }
    }
}
