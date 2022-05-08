using EMY.ECommerceSystem.Core.Application.Abstractions;
using EMY.ECommerceSystem.Infrastructure.Persistence.Concretes;
using EMY.ECommerceSystem.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMY.ECommerceSystem.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {          
            
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
