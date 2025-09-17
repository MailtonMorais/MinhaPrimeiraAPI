using MinhaPrimeiraApi.Aplication.Interface;
using MinhaPrimeiraApi.Aplication.Service;
using MinhaPrimeiraApi.Domain.Interface;
using MinhaPrimeiraApi.Infrastructure.DataBase;
using MinhaPrimeiraApi.Infrastructure.Repository;

namespace MinhaPrimeiraApi.API.IoC
{
    public static class DependenceInjection
    {
         public static IServiceCollection RegisterServices(this IServiceCollection services)
         {
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRpository>();
            services.AddSingleton<IDb, DbClient>();
            return services;
         }
    }
}
