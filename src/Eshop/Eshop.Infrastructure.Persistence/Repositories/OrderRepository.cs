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
    public class OrderRepository:Repository<Order>,IOrderRepository
    {
      
        public OrderRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            
        }


        // return List<order>>
	// parameter int id
        public async Task<List<Order>> GetByCustomerId(int id)
        {
           return await _applicationDbContext.Set<Order>().Where(x => x.CustomerId == id).ToListAsync();

        }
        // return order
        // parameter int id, int customerid
        public async Task<Order> GetByCustomerIdOrder(int id, int customerId)
        {
            return await _applicationDbContext.Set<Order>().Where(x => x.Id == id && x.CustomerId == customerId).FirstOrDefaultAsync();
        }
    }
}
