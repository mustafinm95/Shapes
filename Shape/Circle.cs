using TestTask.Shape.Interfaces;

namespace TestTask.Shape
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Negative radius");
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
