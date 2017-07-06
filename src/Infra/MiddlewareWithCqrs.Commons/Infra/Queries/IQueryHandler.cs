using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Commons.Infra.Queries
{
    public interface IQueryHandler<TRequest, TResult> where TRequest : QueryRequest
    {
        TResult Handle(TRequest query);
    }
}
