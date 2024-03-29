﻿using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Entities;
using Eshop.Infrastructure.Persistence.DbContexts;
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

        public bool Login(Customer customer)
        {
            var user = _applicationDbContext.Customers.FirstOrDefault(x => x.Email == customer.Email && x.Password == customer.Password);
            return user != null;
        }
    }
}

