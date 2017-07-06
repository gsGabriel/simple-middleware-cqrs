using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;
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
            await _next.Invoke(context);
        }
    }

    public static class AddTodoMiddlewareExtensions
    {
        public static IApplicationBuilder UseAddTodoMiddleware(this IApplicationBuilder app, AddTodoMiddlewareOptions options)
        {
            var url = $"api/mypath/{{id}}";

            var routeBuilder = new RouteBuilder(app);

            app.UseMiddleware<AddTodoMiddleware>(new OptionsWrapper<AddTodoMiddlewareOptions>(options));

            return app;
        }
    }

    public class AddTodoMiddlewareOptions
    {
    }
}
