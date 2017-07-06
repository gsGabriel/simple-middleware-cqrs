using MiddlewareWithCqrs.Commons.Infra.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Domain.Todo.Contracts.Commands
{
    public class AddTodoCommand : Command
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
