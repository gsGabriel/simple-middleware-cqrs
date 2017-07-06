using MiddlewareWithCqrs.Commons.Infra.Commands;
using MiddlewareWithCqrs.Domain.Todo.Contracts.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Domain.Todo.CommandHandlers
{
    public class AddTodoCommandHandler : ICommandHandler<AddTodoCommand>
    {
        public AddTodoCommand Handle(AddTodoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
