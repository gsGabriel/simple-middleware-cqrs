using MiddlewareWithCqrs.Commons.Infra.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Domain.Todo.Contracts.QueryRequests
{
    public class ListTodoQueryRequest : QueryRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
