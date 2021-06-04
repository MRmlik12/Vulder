using Autofac;
using Vulder.Search.Core.Interfaces;
using Vulder.Search.Core.Services;

namespace Vulder.Search.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SchoolsCollectionService>()
                .As<ISchoolCollectionService>().InstancePerLifetimeScope();
        }
    }
}