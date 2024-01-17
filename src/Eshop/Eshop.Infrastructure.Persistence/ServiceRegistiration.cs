using Eshop.Infrastructure.Persistence.DbContexts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Eshop.Infrastructure.Persistence
{
    static public class ServiceRegistiration
    {
        public static  void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddDbContext<ApplicationDbContext>();
          
        }
    }
}
