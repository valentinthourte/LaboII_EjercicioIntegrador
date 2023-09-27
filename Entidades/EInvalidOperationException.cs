using System.Runtime.Serialization;

namespace Calculadora_ValentinThourte
{
    [Serializable]
    internal class EInvalidOperationException : Exception
    {
        public EInvalidOperationException()
        {
        }

        public EInvalidOperationException(string? message) : base(message)
        {
        }

        public EInvalidOperationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EInvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}