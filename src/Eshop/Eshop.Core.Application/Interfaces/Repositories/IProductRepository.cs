using Eshop.Core.Application.Dto;
using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public  interface IProductRepository:IRepository<Product>
    {
        Task<CategoryIdProductDto> GetByCatId(int id, int numberOfProductsPerPage, int currentPage = 1);
        Task<ProductDto> GetPerPageProducts(int numberOfProductsPerPage, int currentPage = 1);
    }
}
