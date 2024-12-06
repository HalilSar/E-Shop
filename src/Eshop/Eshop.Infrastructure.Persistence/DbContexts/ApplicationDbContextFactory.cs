using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.DbContexts
{
    public class ApplicationDbContextFactory:DesignTimeDbContextFactory<ApplicationDbContext>
    {
        // Return      ApplicationDbContext
	// Parameter   DbContextOptions<ApplicationDbContext> options
	protected override ApplicationDbContext CreateNewInstance(DbContextOptions<ApplicationDbContext> options)
        {
            return new ApplicationDbContext(options);
        }
    }
}
