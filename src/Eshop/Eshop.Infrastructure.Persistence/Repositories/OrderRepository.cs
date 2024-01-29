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
        private readonly ApplicationDbContext _applicationDbContext;
        public OrderRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        public async Task<List<Order>> GetByCustomerId(int id)
        {
           return await _applicationDbContext.Set<Order>().Where(x => x.CustomerId == id).ToListAsync();

        }

        public async Task<Order> GetByCustomerIdOrder(int id, int customerId)
        {
            return await _applicationDbContext.Set<Order>().Where(x => x.Id == id && x.CustomerId == customerId).FirstOrDefaultAsync();
        }
    }
}
