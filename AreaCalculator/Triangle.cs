namespace Area_Calculator
{
    public class Triangle : FigureBase
    {
        public Point A {  get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public double ABLength { get; }
        public double BCLength { get; }
        public double CALength { get; }

        public Triangle(Point a, Point b, Point c)
        {
            if (!IsSingular(a, b, c)) 
                throw new ArgumentException();

            A = a; B = b; C = c;
        }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
        public bool IsRectangular()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns true if some points match.</returns>
        private bool IsSingular(Point a, Point b, Point c)
        {
            return a == b || b == c || c == a;
        }
    }
}
