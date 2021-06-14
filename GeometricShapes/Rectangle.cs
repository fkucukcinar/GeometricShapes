using System.Linq;

namespace GeometricShapes
{
    public class Rectangle : GeometricShape, ShapeInterface, PolygonInterface
    {
        private readonly int x;
        private readonly int y;
        public Rectangle(object[] parameters)
        {
            int[] parametrs = parameters.Cast<int>().ToArray();
            this.x = parametrs.ToList()[0];
            this.y = parametrs.ToList()[1];
        }
        public double GetArea()
        {
            return x * y;
            
        }

        public double GetPerimeter()
        {
            return 2 * (x + y);
        }
        public int GetAngles()
        {
            return 4;
        }
    }
}
