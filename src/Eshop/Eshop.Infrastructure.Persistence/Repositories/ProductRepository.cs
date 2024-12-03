using Eshop.Core.Application.Dto;
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

        public ProductRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }
	// return    CategoryIdProductDto
	// parameters : int id, int numberOfProductsPerPage, int currentPage = 1
        public async Task<CategoryIdProductDto> GetByCatId(int id, int numberOfProductsPerPage, int currentPage = 1)
        {
            var catlist = await _applicationDbContext.Set<Product>().Where(x => x.CategoryId == id).ToListAsync();
            int pageCount = Convert.ToInt32(Math.Round(Convert.ToDecimal(catlist.Count) / numberOfProductsPerPage));
            return new CategoryIdProductDto { 
                                              Products = catlist.Skip(numberOfProductsPerPage * (currentPage - 1)).Take(numberOfProductsPerPage).ToList(),
                                              PageCount = pageCount,
                                              CurrentPage=currentPage
                                            };
        }
        // return      ProductDto
	// parameters: int numberOfProductsPerPage, int currentPage = 1
        public async Task<ProductDto> GetPerPageProducts(int numberOfProductsPerPage, int currentPage = 1)
        {
            var product = await Get();
            int pageCount = Convert.ToInt32(Math.Round(Convert.ToDecimal(product.Count) / numberOfProductsPerPage));
 
            return  new ProductDto {
                                        Products =product.Skip(numberOfProductsPerPage * (currentPage - 1))
                                        .Take(numberOfProductsPerPage).ToList(), 
                                        PageCount=pageCount,
                                        CurrentPage=currentPage };
               
        }
    }
}
