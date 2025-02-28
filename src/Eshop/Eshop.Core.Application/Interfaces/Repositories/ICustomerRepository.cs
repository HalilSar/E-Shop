﻿using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Interfaces.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
       // Return    : bool
       // Parameter : Customer customer
       Task<bool> Login(Customer customer);
        
    }
}
