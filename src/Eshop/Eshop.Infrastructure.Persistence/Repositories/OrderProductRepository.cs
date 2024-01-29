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
    public class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public OrderProductRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task CreateOrders(int customerId,int orderId)
        {
            var carts =_applicationDbContext.CartItems.Where(i=>i.CustomerId==customerId);
            foreach (var item in carts)
            {
                var orderProduct = new OrderProduct
                {
                     OrderId = orderId,
                     Amount=item.Amount,
                     ProductId=item.ProductId,
                     SubTotal=item.SubTotal,
                    
                };
               await  this.Add(orderProduct);
            }
        }

        public  async Task< List<OrderProduct>> GetByOrderId(int id,int customerId)
        {
            return  await _applicationDbContext.Set<OrderProduct>().Where(x => x.OrderId == id && x.CustomerId==customerId).ToListAsync();

        }
    }
}
