using System;
using System.Runtime.Serialization;

namespace TemplateTestApplication.Domain
{
    public class BalanceDroppedBelowZeroException : Exception
    {
        public BalanceDroppedBelowZeroException()
        {
        }

        public BalanceDroppedBelowZeroException(string message) : base(message)
        {
        }

        public BalanceDroppedBelowZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BalanceDroppedBelowZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
