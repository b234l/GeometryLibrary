namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double CalculateArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
            return area;
        }
        public bool IsRightTriangle()
        {
            bool isRight = Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2)
                || Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2)
                || Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2);
            return isRight;
        }
    }
}