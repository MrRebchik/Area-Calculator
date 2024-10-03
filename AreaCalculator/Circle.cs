namespace Area_Calculator
{
    public class Circle : FigureBase
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(double radius) : this(radius, Point.Zero)
        { }
        public Circle(double radius, Point center)
        {
            if (!IsValidRadius(radius))
                throw new ArgumentException("The radius must be greater than 0");
            Center = center; 
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private bool IsValidRadius(double r)
        {
            return r > 0;
        }
    }
}
