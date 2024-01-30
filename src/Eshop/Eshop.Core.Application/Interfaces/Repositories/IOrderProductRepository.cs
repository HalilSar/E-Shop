using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
  public  interface IOrderProductRepository:IRepository<OrderProduct>
    {
        Task CreateOrderProducts(List<CartItem> cartItems, int customerId, int orderId);
        Task<List<OrderProduct>> GetByOrderId(int id,  int customerId);
    }
}
