using GeometricShapes;
using System;
using Xunit;

namespace GeometricShapesTests
{
    public class TestRectangle
    {
        [Fact]
        public void testRectangle()
        {
            try
            {
                GeometricShape shapeObject = (GeometricShape)ShapeFactory.CreateShape("Rectangle", new Object[] { 3, 2 });
                ShapeInterface shapeInterfaceObject = shapeObject as ShapeInterface;
                PolygonInterface polygonInterfaceObject = shapeObject as PolygonInterface;

                Assert.NotNull(shapeObject);
                Assert.Equal("Rectangle", shapeObject.getName());

                Assert.NotNull(shapeInterfaceObject);
                Assert.Equal(10, shapeInterfaceObject.GetPerimeter());
                Assert.Equal(6, shapeInterfaceObject.GetArea());

                Assert.NotNull(polygonInterfaceObject);
                Assert.Equal(4, polygonInterfaceObject.GetAngles());
            }
            catch (UnsupportedShapeException)
            {
                Assert.True(false, "Rectangle test failed: unsupported shape");
            }
            catch (WrongParamCountException)
            {
                Assert.True(false, "Rectangle test failed: wrong number of shape parameters");
            }
        }
    }
}
