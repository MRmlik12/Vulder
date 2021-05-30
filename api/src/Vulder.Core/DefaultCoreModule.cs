using Autofac;
using Vulder.Core.Interfaces;
using Vulder.Core.Services;

namespace Vulder.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SchoolsCollectionService>()
                .As<ISchoolsCollectionService>().InstancePerLifetimeScope();
        }
    }
}