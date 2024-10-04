namespace Area_Calculator
{
    public class Circle : FigureBase
    {
        public Vector2 Center { get; set; }
        public double Radius { get; set; }

        public Circle(double radius) : this(radius, Vector2.Zero)
        { }
        public Circle(double radius, Vector2 center)
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
