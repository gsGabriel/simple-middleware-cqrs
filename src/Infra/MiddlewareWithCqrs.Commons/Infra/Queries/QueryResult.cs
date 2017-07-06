using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Commons.Infra.Queries
{
    public class QueryResult<T>
    {
        public IEnumerable<T> Data { get; set; }
    }
}
