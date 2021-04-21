using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Nubank.Application.Servicos.Clientes;
using Nubank.Domain.Core.Bus;
using Nubank.Domain.Core.Notifications;
using Nubank.Domain.Models.Clientes;
using Nubank.Infra.CrossCutting.Bus;
using Nubank.Infra.Data.Mocks;
using Nubank.Infra.Data.Repositories.Clientes;

namespace Nubank.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<DataStore>();
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            //Repositories
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();

            //Services
            services.AddTransient<IClienteServico, ClienteServico>();
        }
    }
}