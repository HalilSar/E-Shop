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
        List<Order> GetByCustomerId(int id);
        Order GetByCustomerIdOrder(int id, int customerId);

    }
}
