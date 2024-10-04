namespace Area_Calculator
{
    // В данном классе в отличие от класса System.Numetrics.Vector2
    // для хранения координат используется тип данных double с повышенной точностью, а не float.
    // Во-первых, повышенная точность может потребоваться пользователям, создаюшим научно-прикладные продукты.
    // Во-вторых, double не требует суфикса при записи вещественных литералов. Это приятный бонус.
    public class Vector2
    {
        public double X;
        public double Y;
        public Vector2(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public static Vector2 Zero = new Vector2(0, 0);
        public override bool Equals(object vector)
        {
            return Equals(vector as Vector2);
        }
        public bool Equals(Vector2 vector)
        {
            return X == vector.X && Y == vector.Y;
        }
        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.X + b.X, a.Y + b.Y);
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.X - b.X, a.Y - b.Y);

        public double Distance(Vector2 a)
        {
            return Math.Sqrt(Math.Pow(X - a.X, 2) + Math.Pow(Y - a.Y, 2));
        }

    }
}