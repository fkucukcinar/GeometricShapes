using GeometricShapes;
using System;
using Xunit;

namespace GeometricShapesTests
{
    public class TestCircle
    {
        [Fact]
        private void testCircle()
        {
            try
            {
                GeometricShape shapeObject = (GeometricShape)ShapeFactory.CreateShape("Circle", new Object[] { 4 });
                ShapeInterface shapeInterfaceObject = shapeObject as ShapeInterface;
                PolygonInterface polygonInterfaceObject = shapeObject as PolygonInterface;

                Assert.NotNull(shapeObject);
                Assert.Equal("Circle", shapeObject.getName());

                Assert.NotNull(shapeInterfaceObject);
                Assert.Equal(25.12, shapeInterfaceObject.GetPerimeter(), 2);
                Assert.Equal(50.24, shapeInterfaceObject.GetArea(), 2);

                Assert.Null(polygonInterfaceObject);
            }
            catch (UnsupportedShapeException)
            {
                Assert.True(false, "Circle test failed: unsupported shape");
            }
            catch (WrongParamCountException)
            {
                Assert.True(false, "Circle test failed: wrong number of shape parameters");
            }
        }
    }
}
