using Area_Calculator;

namespace AreaCalculatorTests
{
    public class Vector2UnitTests
    {
        [Fact]
        public void DefaultCtorTest()
        {
            var vector = new Vector2();

            Assert.Equal(Vector2.Zero, vector);
        }

        [Fact]
        public void VectorsEqualsTest()
        {
            var vector1 = new Vector2(2, 2);
            var vector2 = new Vector2(2, 2);
            var vector3 = new Vector2(3, 3);

            Assert.True(vector1.Equals(vector2));
            Assert.False(vector1.Equals(vector3));
        }

        [Fact]
        public void VectorSumTest()
        {
            var vector1 = new Vector2(1, 2);
            var vector2 = new Vector2(2, 1);
            var vector3 = new Vector2(-1, -2);

            Assert.Equal(new Vector2(3,3), vector1 + vector2);
            Assert.Equal(Vector2.Zero, vector1 + vector3);
        }

        [Fact]
        public void VectorDifferenceTest()
        {
            var vector1 = new Vector2(1, 2);
            var vector2 = new Vector2(2, 1);
            var vector3 = new Vector2(-1, -2);

            Assert.Equal(new Vector2(-1, 1), vector1 - vector2);
            Assert.Equal(new Vector2(2, 4), vector1 - vector3);
        }

        [Fact]
        public void VectorDistanceTest()
        {
            var vector1 = new Vector2(1, 0);
            var vector2 = new Vector2(0, 5);
            var vector3 = new Vector2(3, 4);

            Assert.Equal(1, Vector2.Zero.Distance(vector1));
            Assert.Equal(5, Vector2.Zero.Distance(vector2));
            Assert.Equal(5, Vector2.Zero.Distance(vector3));
        }
    }
    public class CircleUnitTests
    {
        [Fact]
        public void OneArgumentCtorTest()
        {
            var circle = new Circle(1); 

            Assert.Equal(Vector2.Zero, circle.Center);
        }

        [Fact]
        public void TwoArgumentCtorTest()
        {
            var circle = new Circle(1, new Vector2(2,4));

            Assert.Equal(new Vector2(2, 4), circle.Center);
            Assert.Equal(1, circle.Radius);
        }

        [Fact]
        public void IncorrectArgumentCtorTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(double.MinValue, new Vector2(2, 4)));
        }

        [Fact]
        public void GetAreaTest()
        {
            var circle1 = new Circle(1);

            double secondCircleRadius = 4;
            var circle2 = new Circle(secondCircleRadius);

            Assert.Equal(Math.PI, circle1.GetArea());
            Assert.Equal(Math.PI * Math.Pow(secondCircleRadius,2), circle2.GetArea());
        }
    }
    public class TriangleUnitTests
    {
        [Fact]
        public void IsRectangularTest()
        {
            var triangle = new Triangle(new Vector2(0,0), new Vector2(1,0), new Vector2(0,6));

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void GetAreaTest()
        {
            var triangle = new Triangle(new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 6));
            double expectedArea = 3;
            double epsilon = 0.00000000000001;

            Assert.True(triangle.GetArea() - expectedArea < epsilon);
        }

    }
}