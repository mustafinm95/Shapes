namespace TestTask.Shape.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturn_CorrectArea()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();
            Assert.Equal(78.53981633974483, area, 6);
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_RadiusIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
