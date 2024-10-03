namespace Area_Calculator
{
    public class Point
    {
        public double X;
        public double Y;
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public static Point Zero = new Point(0, 0);
        public static Point operator +(Point a, Point b) { throw new Exception(); }
        public static Point operator -(Point a, Point b) { throw new Exception(); }

    }
}
