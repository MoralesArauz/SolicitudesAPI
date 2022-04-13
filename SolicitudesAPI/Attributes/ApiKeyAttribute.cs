using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;



namespace SolicitudesAPI.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.All)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        // Estamos creando un atributo que usaremos como decoracion para nuestros 
        // controllers e inyectarle el mecanismo de seguridad de ApiKey a nuestros end points

        private const string NombreDelApiKey = "ApiKey";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(NombreDelApiKey, out var ApiSalida))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "No se ha incluido una ApiKey"
                };
                return;
            }

            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            var apiKey = appSettings.GetValue<string>(NombreDelApiKey);

            if (!apiKey.Equals(ApiSalida))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "La API Key suministrada no es la correcta!"
                };
                return;
            }

            await next();
        } 

    }
}
