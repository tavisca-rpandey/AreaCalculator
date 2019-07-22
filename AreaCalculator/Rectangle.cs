using System;

namespace AreaCalculator
{
    public class Rectangle:Shape
    {
        double height, breadth;
        public Rectangle(double height, double breadth) : base()
        {
            this.height = height;
            this.breadth = breadth;
            area = this.GetArea();
        }

        public override double GetArea()
        {
            area = height * breadth;
            return area;
        }
        public override void ShowArea()
        {
            
            Console.WriteLine($"Area of Rectangle={area}");
        }
    }
}