using MinhaPrimeiraApi.Aplication.Interface;
using MinhaPrimeiraApi.Aplication.Service;
using MinhaPrimeiraApi.Domain.Interface;
using MinhaPrimeiraApi.Domain.Model;
using MinhaPrimeiraApi.Infrastructure.DataBase;
using MinhaPrimeiraApi.Infrastructure.Repository;

namespace MinhaPrimeiraApi.API.IoC
{
    public static class DependenceInjection
    {
         public static IServiceCollection RegisterServices(this IServiceCollection services)
         {
            services.AddSingleton<IBancoDeDados, BancoDeDados>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRpository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
         }
       
    }
}
