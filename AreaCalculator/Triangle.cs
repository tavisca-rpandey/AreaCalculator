using System;
namespace AreaCalculator
{
    public class Triangle : Shape
    {
        double side1,side2,side3;
        public Triangle(double s1, double s2, double s3) : base()
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            area = this.GetArea();

        }

        public override  double GetArea()
        {
            area = 0;
            return area;
        }

        public override void ShowArea()
        {
             Console.WriteLine($"Area of Triangle ={area}");
        }
    }
}