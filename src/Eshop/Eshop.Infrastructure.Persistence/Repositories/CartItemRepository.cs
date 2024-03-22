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
    public  class CartItemRepository:Repository<CartItem>,ICartItemRepository
    {
        
        public CartItemRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
           
        }

        public async Task DeleteCartItems(List<CartItem> cartItems)
        {
            _applicationDbContext.CartItems.RemoveRange(cartItems);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<CartItem>> GetByCustormerId(int id)
        {
            return await _applicationDbContext.Set<CartItem>().Where(x => x.CustomerId == id).ToListAsync();
        }
    }
}
