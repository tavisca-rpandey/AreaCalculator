using System;
using Xunit;
using AreaCalculator;
namespace AreaCalcXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void RecTest()
        {
            Rectangle r1 = new Rectangle(12.4, 4.5);
            Assert.Equal(12.4 * 4.5, r1.area);
        }


        [Fact]
        public void CircTest()
        {
            Circle r1 = new Circle(4.5);
            Assert.Equal(4.5 * 4.5 * 3.14, r1.area);
        }

        [Fact]
        public void SqTest()
        {
            Square r1 = new Square(12.4);
            Assert.Equal(12.4 * 12.4, r1.area);
        }

        [Fact]
        public void TriTest()
        {
            Triangle r1 = new Triangle(12.4, 4.5, 2.1);
            Assert.Equal(0, r1.area);
        }
    }
}
