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
	// Parameters : List<CartItem> cartItems, int customerId, int orderId)    
        Task CreateOrderProducts(List<CartItem> cartItems, int customerId, int orderId);
	// Parameters : int id,  int customerId
        Task<List<OrderProduct>> GetByOrderId(int id,  int customerId);
    }
}
