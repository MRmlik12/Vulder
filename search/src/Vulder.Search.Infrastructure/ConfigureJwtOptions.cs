using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

namespace Vulder.Search.Infrastructure
{
    public class ConfigureJwtOptions : IPostConfigureOptions<JwtBearerOptions>
    {
        public void PostConfigure(string name, JwtBearerOptions options)
        {
            var originalOnMessageReceived = options.Events.OnMessageReceived;
            options.Events.OnMessageReceived = async context =>
            {
                await originalOnMessageReceived(context);
                
                if (string.IsNullOrEmpty(context.Token))
                {
                    var accessToken = context.Request.Query["token"];
                    var path = context.HttpContext.Request.Path;
                
                    if (!string.IsNullOrEmpty(accessToken) && 
                        path.StartsWithSegments("/searchHub"))
                    {
                        context.Token = accessToken;
                    }
                }
            };
        }
    }
}