using System;
using Microsoft.Extensions.DependencyInjection;
using Vulder.Search.Infrastructure.Data;
using Vulder.Search.Infrastructure.Data.Configuration;

namespace Vulder.Search.Infrastructure
{
    public static class StartupSetup
    {
        public static void AddMongoDbContext(this IServiceCollection services) =>
            services.AddSingleton<MongoDbContext>();
    }
}