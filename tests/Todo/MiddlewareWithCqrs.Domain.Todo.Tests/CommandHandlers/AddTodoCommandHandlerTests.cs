using MiddlewareWithCqrs.Domain.Todo.CommandHandlers;
using MiddlewareWithCqrs.Domain.Todo.Contracts.Commands;
using System;
using Xunit;

namespace MiddlewareWithCqrs.Domain.Todo.Tests
{
    public class AddTodoCommandHandlerTests
    {
        [Fact]
        public void CallHandle()
        {
            var handler = new AddTodoCommandHandler();

            var ex = Assert.Throws<NotImplementedException>(() => handler.Handle(new AddTodoCommand()));
            Assert.IsType(typeof(NotImplementedException), ex);
        }
    }
}
