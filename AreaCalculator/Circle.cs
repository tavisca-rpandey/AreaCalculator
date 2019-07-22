using System;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        double radius;
        public Circle(double rad): base()
        {
            radius = rad;
            area = this.GetArea();
        }

       public override double GetArea()
        {
            area = 3.14 * radius * radius;
            return area;
        }

        public override void ShowArea()
        {

            Console.WriteLine($"Area of Circle={area}");
        }
    }
}