using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Exceptions
{
    public class InvalidAttributeSizeException : BusinessRuleException
    {
        public InvalidAttributeSizeException()
        {
        }
        public InvalidAttributeSizeException(string attribute) : base(ErrorMessageBuilder(attribute, null, null))
        {
        }
        public InvalidAttributeSizeException(string attribute, int? minSize, int? maxSize) : base(ErrorMessageBuilder(attribute, minSize, maxSize))
        {
        }
        private static string ErrorMessageBuilder(string attribute, int? minSize, int? maxSize)
        {
            StringBuilder sb = new("Invalid" + attribute + " field value range");
            if (minSize.HasValue)
            {
                sb.Append($" Mininum value: {minSize.Value}.");
            }
            if (maxSize.HasValue)
            {
                sb.Append($" Maximum value: {maxSize.Value}.");
            }
            return sb.ToString();
        }

        protected InvalidAttributeSizeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
}
