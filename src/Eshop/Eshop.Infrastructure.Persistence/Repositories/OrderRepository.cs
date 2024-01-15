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
    public class OrderRepository:Repository<Order>,IOrderRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public OrderRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Order> GetByCustomerId(int id)
        {
           return  _applicationDbContext.Set<Order>().Where(x => x.CustomerId == id).ToList();

        }

        public Order GetByCustomerIdOrder(int id, int customerId)
        {
            return _applicationDbContext.Set<Order>().Where(x => x.Id == id && x.CustomerId == customerId).FirstOrDefault();
        }
    }
}
