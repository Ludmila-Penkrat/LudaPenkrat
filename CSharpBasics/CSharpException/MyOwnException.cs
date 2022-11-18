
namespace CSharpException
{
    public class TriangleException : Exception
    {
        public double Value { get; }

        public TriangleException() { }

        public TriangleException(string message) : base(message) { }

        public TriangleException(string message, Exception innerException) : base(message, innerException) { }

        public TriangleException(string message, double value) 
        {
            Value = value;
        }
    }
}
