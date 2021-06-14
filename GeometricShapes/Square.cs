using System.Linq;

namespace GeometricShapes
{
    public class Square : GeometricShape, ShapeInterface, PolygonInterface
    {

        private readonly int x;
       
        public Square(object[] parameters)
        {
            int[] parametrs = parameters.Cast<int>().ToArray();
            this.x = parametrs.ToList()[0];
        }

        public double GetArea()
        {
            return x * x;
        }

        public double GetPerimeter()
        {
            return 4 * x;
        }
        public int GetAngles()
        {
            return 4;
        }
    }
}
