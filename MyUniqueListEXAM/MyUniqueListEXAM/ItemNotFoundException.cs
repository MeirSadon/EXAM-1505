using System;
using System.Runtime.Serialization;

namespace SecretAgent
{
    [Serializable]
    internal class ItemNotFoundException : ApplicationException
    {
        public ItemNotFoundException()
        {
        }

        public ItemNotFoundException(string message) : base(message)
        {
        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}