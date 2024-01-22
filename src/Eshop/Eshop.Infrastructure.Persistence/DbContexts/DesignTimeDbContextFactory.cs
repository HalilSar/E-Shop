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
        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);
        public TContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TContext> builder = new DbContextOptionsBuilder<TContext>();
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Eshop.Presentation."))
                .AddJsonFile("appsettings.Development.json").Build();
            builder.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
            return CreateNewInstance(builder.Options);

        }
    }
}
