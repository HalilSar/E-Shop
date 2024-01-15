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
    public  class CartItemRepository:Repository<CartItem>,ICartItemRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CartItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<CartItem> GetByCustormerId(int id)
        {
            return _applicationDbContext.Set<CartItem>().Where(x => x.CustomerId == id).ToList();
        }
    }
}
