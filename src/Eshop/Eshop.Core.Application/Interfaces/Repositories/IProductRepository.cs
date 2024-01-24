﻿using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public  interface IProductRepository:IRepository<Product>
    {
        Task<List<Product>> GetByCatId(int id);
        Task<List<Product>> GetPerPageProducts(int numberOfProductsPerPage);
    }
}
