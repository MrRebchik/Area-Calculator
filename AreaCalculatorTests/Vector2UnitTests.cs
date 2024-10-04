using Area_Calculator;

namespace AreaCalculatorTests
{
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
            Assert.Throws<ArgumentException>(() => new Circle(0, new Vector2(2, 4)));
        }
    }
}