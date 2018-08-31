using System.Reflection;
using Autofac;
using Infrastructure.CQRS.CommandDispatcher;
using Infrastructure.CQRS.CommandHandler;
using Infrastructure.CQRS.QueryProccesor;
using Module = Autofac.Module;

namespace Presentation.AutoFac
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>();
            
            builder.RegisterAssemblyTypes(Assembly.Load("Application")).AsClosedTypesOf(typeof(IDomainCommandHandler<>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.Load("Application")).AsClosedTypesOf(typeof(IDomainQueryHandler<,>))
                .AsImplementedInterfaces();
        }
    }
}