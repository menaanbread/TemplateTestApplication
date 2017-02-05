using System;
using System.Runtime.Serialization;

namespace TemplateTestApplication.Domain
{
    public class UnsupportedTransactionMethodException : Exception
    {
        public UnsupportedTransactionMethodException()
        {
        }

        public UnsupportedTransactionMethodException(string message) : base(message)
        {
        }

        public UnsupportedTransactionMethodException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnsupportedTransactionMethodException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
