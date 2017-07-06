using System;
using System.Collections.Generic;
using System.Text;

namespace MiddlewareWithCqrs.Commons.Infra.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        TCommand Handle(TCommand command);
    }
}
