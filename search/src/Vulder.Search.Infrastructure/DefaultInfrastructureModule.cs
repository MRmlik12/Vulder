using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Module = Autofac.Module;
using MediatR;
using MediatR.Pipeline;
using Vulder.Search.Core.ProjectAggregate.School;

namespace Vulder.Search.Infrastructure
{
    public class DefaultInfrastructureModule : Module
    {
        private readonly List<Assembly> _assemblies = new();
        
        public DefaultInfrastructureModule()
        {
            _assemblies.Add(Assembly.GetAssembly(typeof(School)));
        }
        
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Mediator>()
                .As<IMediator>().InstancePerLifetimeScope();

            builder.Register<ServiceFactory>(context =>
            {
                return t => context.Resolve<IComponentContext>().Resolve(t);
            });
            
            var mediatROpenTypes = new[]
            {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionHandler<,>),
                typeof(INotificationHandler<>),
            };
            
            foreach (var mediatROpenType in mediatROpenTypes)
            {
                builder.RegisterAssemblyTypes(_assemblies.ToArray())
                    .AsClosedTypesOf(mediatROpenType)
                    .AsImplementedInterfaces();
            }
        }
    }
}