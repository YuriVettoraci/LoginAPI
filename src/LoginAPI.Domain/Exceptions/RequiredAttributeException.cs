using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Exceptions
{
    public class RequiredAttributeException : BusinessRuleException
    {
        public RequiredAttributeException()
        {
        }
        public RequiredAttributeException(string attribute) : base(attribute + " is required")
        {

        }

        protected RequiredAttributeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
}
