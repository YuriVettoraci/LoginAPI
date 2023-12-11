using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Exceptions
{
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException()
        {
        }

        public BusinessRuleException(string message) : base(message)
        {

        }

        public BusinessRuleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BusinessRuleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
}
