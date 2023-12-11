using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAPI.Domain.Util
{
    public class QueryPagination<T> where T : class
    {
        public long Total { get; set; }
        public IEnumerable<T> Records { get; set; }
    }
}
