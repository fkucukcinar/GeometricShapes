using System.Collections.Generic;
using System.Linq;

namespace GeometricShapes
{
    public class Circle : GeometricShape, ShapeInterface
    {
        private readonly int radius;
        public Circle(object[] parameters)
        {
            int[] parametrs = parameters.Cast<int>().ToArray();
            this.radius = parametrs.ToList()[0];
        }
        public double GetArea()
        {
            return Constants.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Constants.PI * radius;
        }
    }
}
