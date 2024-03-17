namespace bai2_07
{
    public class Circle
    {
        public double radius;
        public string color;
        public bool filled;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }
        public double getRadius()
        {
            return radius;
        }
    }
}
