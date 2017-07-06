using MiddlewareWithCqrs.Commons.Infra.Queries;
using MiddlewareWithCqrs.Domain.Todo.Contracts.QueryRequests;
using MiddlewareWithCqrs.Domain.Todo.Contracts.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Domain.Todo.QueryHandlers
{
    public class ListTodoQueryHandler : IQueryHandler<ListTodoQueryRequest, QueryResult<ListTodoResult>>
    {
        public QueryResult<ListTodoResult> Handle(ListTodoQueryRequest query)
        {
            throw new NotImplementedException();
        }
    }
}
