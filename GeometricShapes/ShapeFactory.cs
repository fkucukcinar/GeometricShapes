using System;

namespace GeometricShapes
{
    
    public class ShapeFactory
    {
        /// <summary>
        /// Creates a specific GeometricShape object from the given attributes.
        /// 
        /// Usage examples:
        ///     ShapeFactory.CreateShape("Circle", new Object[] { 4 })
        ///     ShapeFactory.CreateShape("Rectangle", new Object[] { 3, 5 })
        /// </summary>
        /// <param name="shape">Shape to create.</param>
        /// <param name="parameters">Array of needed parameters.</param>
        /// <returns></returns>
        public static object CreateShape(string shape, object[] parameters)
        {
            /// ToDo
            ShapeInterface shp = null;
            if (shape == "Rectangle")
                shp = new Rectangle(parameters);
            else if (shape == "Circle")
                shp = new Circle(parameters);
            else if (shape == "Square")
                shp = new Square(parameters);
            return (GeometricShape) shp;
        }
    }
}
