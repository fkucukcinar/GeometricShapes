using System;

namespace GeometricShapes
{
    public class UnsupportedShapeException : Exception
    {
        public UnsupportedShapeException() : base(String.Format("Unsupported Shape Exception"))
        {

        }
    }

}
