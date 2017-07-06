using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;
using MiddlewareWithCqrs.Domain.Todo.CommandHandlers;
using MiddlewareWithCqrs.Domain.Todo.Contracts.Commands;
using System.Threading.Tasks;

namespace MiddlewareWithCqrs.Middlewares.Todo.Middlewares
{
    public class AddTodoMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AddTodoMiddlewareOptions _options;

        public AddTodoMiddleware(RequestDelegate next, IOptions<AddTodoMiddlewareOptions> optionsAccessor)
        {
            _next = next;
            _options = optionsAccessor.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            var result = new AddTodoCommandHandler().Handle(new AddTodoCommand());
            await _next.Invoke(context);
        }
    }

    public static class AddTodoMiddlewareExtensions
    {
        public static IApplicationBuilder UseAddTodoMiddleware(this IApplicationBuilder app, AddTodoMiddlewareOptions options)
        {
            return app.UseMiddleware<AddTodoMiddleware>(new OptionsWrapper<AddTodoMiddlewareOptions>(options));
        }

        public static IApplicationBuilder UseAddTodoRoutes(this IApplicationBuilder app, AddTodoMiddlewareOptions options, string url)
        {
            return app.UseRouter(new RouteBuilder(app).MapPost(url, context => new AddTodoCommandHandler().Handle(new AddTodoCommand())).Build());
        }
    }

    public class AddTodoMiddlewareOptions
    {
    }
}
