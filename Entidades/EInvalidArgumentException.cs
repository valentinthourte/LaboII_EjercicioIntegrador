using System.Runtime.Serialization;

namespace Calculadora_ValentinThourte
{
    [Serializable]
    internal class EInvalidArgumentException : Exception
    {
        public EInvalidArgumentException()
        {
        }

        public EInvalidArgumentException(string? message) : base(message)
        {
        }

        public EInvalidArgumentException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EInvalidArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}