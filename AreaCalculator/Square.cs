using System;

namespace AreaCalculator
{
   public class Square : Shape
    {
        double side;
        public Square(double side) : base()
        {
            this.side = side;
            area = this.GetArea();
        }

        public override double GetArea()
        {
            area = side * side;
            return area;
        }

        public override void ShowArea()
        {
          
            Console.WriteLine($"Area of Square={area}");
        }
    }
}