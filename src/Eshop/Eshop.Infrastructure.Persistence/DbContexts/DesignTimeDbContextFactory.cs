using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.DbContexts
{
    public abstract class DesignTimeDbContextFactory<TContext> : IDesignTimeDbContextFactory<TContext> where TContext:DbContext
    {
	// parameter: DbContextOptions<TContext> options
	// return     TContext
        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options); 

	// parameter string[] args
	// return TContext
        public TContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TContext> builder = new DbContextOptionsBuilder<TContext>();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Eshop.Presentation.Mvc"))
                .AddJsonFile("appsettings.Development.json").Build();
            builder.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
            return CreateNewInstance(builder.Options);
            // Eğer uzaktan  configurationı appsettings.json ile kullancaksan bir classlib. ile bunu yükle önce Microsoft.Extensions.Configuration.Json .
        }
    }
}
