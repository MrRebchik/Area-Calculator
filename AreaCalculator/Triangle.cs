namespace Area_Calculator
{
    public class Triangle : FigureBase
    {
        public Vector2 A {  get; set; }
        public Vector2 B { get; set; }
        public Vector2 C { get; set; }
        public double ABLength { get => A.Distance(B); }
        public double BCLength { get => B.Distance(C); }
        public double CALength { get => C.Distance(A); }

        public Triangle(Vector2 a, Vector2 b, Vector2 c)
        {
            if (!DoSomePointsIntersect(a, b, c)) 
                throw new ArgumentException("Triangular is degenerate. Some points Intersect.");

            A = a; B = b; C = c;
        }
        public override double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - ABLength) * (halfPerimeter - BCLength) * (halfPerimeter - CALength));
        }
        public double GetPerimeter()
        {
            return ABLength + BCLength + CALength;
        }
        public bool IsRectangular()
        {
            throw new NotImplementedException();
        }
        private bool DoSomePointsIntersect(Vector2 a, Vector2 b, Vector2 c)
        {
            return a == b || b == c || c == a;
        }
    }
}
