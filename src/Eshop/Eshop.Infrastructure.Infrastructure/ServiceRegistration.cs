using Eshop.Core.Application;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Infrastructure
{
    static public class ServiceRegistration
    {
        static public void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddApplicationServices();
        }
    }
}
