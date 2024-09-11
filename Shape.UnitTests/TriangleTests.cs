namespace TestTask.Shape.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturn_CorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void IsRightAngled_ShouldReturn_True_When_RightAngled()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void IsRightAngled_ShouldReturn_Fasle_When_NotRightAngled()
        {
            // Arranged
            var triangle = new Triangle(5, 6, 7);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_AnySideIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -2, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, -3));            
        }

        [Fact]
        public void Constructor_ShouldThrowException_When_SidesDontBelongToTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}