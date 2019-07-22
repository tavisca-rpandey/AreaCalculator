using System;

namespace AreaCalculator
{
    public abstract class Shape
    {
        public double area;
        public Shape()
        {
            area = 0;
        }
        
        public abstract double GetArea();
        public abstract void ShowArea();
    }
}