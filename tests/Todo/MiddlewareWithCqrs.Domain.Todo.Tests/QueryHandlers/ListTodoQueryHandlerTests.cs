using MiddlewareWithCqrs.Domain.Todo.Contracts.QueryRequests;
using MiddlewareWithCqrs.Domain.Todo.QueryHandlers;
using System;
using Xunit;

namespace MiddlewareWithCqrs.Domain.Todo.Tests
{
    public class ListTodoQueryHandlerTests
    {
        [Fact]
        public void CallHandle()
        {
            var handler = new ListTodoQueryHandler();

            var ex = Assert.Throws<NotImplementedException>(() => handler.Handle(new ListTodoQueryRequest()));
            Assert.IsType(typeof(NotImplementedException), ex);
        }
    }
}
