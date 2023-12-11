using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Exceptions
{
    public class InvalidAttributeException : BusinessRuleException
    {
        public InvalidAttributeException()
        {
        }
        public InvalidAttributeException(string attribute) : base ("invalid " + attribute)
        {
        }

        protected InvalidAttributeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
}
