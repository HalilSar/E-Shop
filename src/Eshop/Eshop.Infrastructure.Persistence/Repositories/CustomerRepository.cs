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
    public class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
        // Return bool
	// Parameter : Customer customer
        public async Task<bool> Login(Customer customer)
        {
            var user = await _applicationDbContext.Customers.FirstOrDefaultAsync(x => x.Email == customer.Email && x.Password == customer.Password);
            return user != null;
        }
    }
}

