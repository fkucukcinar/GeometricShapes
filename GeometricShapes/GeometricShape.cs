
namespace GeometricShapes
{
    /// <summary>
    /// Base class for Geometric objects.
    /// </summary>
    public class GeometricShape
    {
        public string getName()
        {
            return this.GetType().Name;
        }
    }
}
