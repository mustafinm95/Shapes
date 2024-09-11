using TestTask.Shape.Interfaces;

namespace TestTask.Shape
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideB < 0)
                throw new ArgumentException("Negative side size");

            if (!IsTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Sides can't belong to triangle");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
        }

        public bool IsRightAngled()
        {
            var sides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
