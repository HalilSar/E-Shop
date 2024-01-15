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
    public class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public OrderProductRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

 

        public List<OrderProduct> GetByOrderId(int id)
        {
            return _applicationDbContext.Set<OrderProduct>().Where(x => x.OrderId == id).ToList();

        }
    }
}
