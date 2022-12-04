namespace WorkingWithDependencyInjectionandMiddleWare.Models
{
    public class CustomMiddleWare
    {

            private readonly RequestDelegate _next;
            public CustomMiddleWare(RequestDelegate next)
            {
                _next = next;
            }
            public async Task Invoke(HttpContext httpContext)
            {
                await httpContext.Response.WriteAsync("Hellow Custom Middleware \n");
                await _next(httpContext);
            }
        }
        // Extension method used to add the middleware to the HTTP request pipeline.
        public static class MyMiddlewareExtensions
        {
            public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<CustomMiddleWare>();
            }
        }
    }
