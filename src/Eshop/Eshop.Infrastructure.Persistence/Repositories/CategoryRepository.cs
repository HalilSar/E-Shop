using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Entities;
using Eshop.Infrastructure.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.Repositories
{
    public  class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }
    }
}
