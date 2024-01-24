using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Entities;
using Eshop.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ProductRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<Product>> GetByCatId(int id, int numberOfProductsPerPage, int currentPage = 1)
        {
            var catlist = await _applicationDbContext.Set<Product>().Where(x => x.CategoryId == id).ToListAsync();
            return catlist.Skip(numberOfProductsPerPage * (currentPage - 1)).Take(numberOfProductsPerPage).ToList();
        }

        public async Task<List<Product>> GetPerPageProducts(int numberOfProductsPerPage, int currentPage = 1)
        {
            var product = Get().Result;
            return   product.Skip(numberOfProductsPerPage * (currentPage - 1)).Take(numberOfProductsPerPage).ToList();
               
        }
    }
}
