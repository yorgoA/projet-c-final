using System.Runtime.Serialization;

namespace BankSolutionApp
{
    [Serializable]
    internal class SoldeNegException : Exception
    {
        public SoldeNegException()
        {
        }

        public SoldeNegException(string? message) : base(message)
        {
        }

        public SoldeNegException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SoldeNegException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}