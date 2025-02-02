using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
	// Return    : List<Order>
	// Parameter : int id
        Task<List<Order>> GetByCustomerId(int id);
	// Return    : Order
        // Parameter : int id, int customerId
        Task<Order> GetByCustomerIdOrder(int id, int customerId);

    }
}
