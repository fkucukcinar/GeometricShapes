using System;

namespace GeometricShapes
{
    public class WrongParamCountException : Exception
    {
        public WrongParamCountException() : base(String.Format("Wrong Param Count Exception"))
        {

        }
    }
}
