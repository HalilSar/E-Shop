﻿using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Eshop.Core.Application.Interfaces.Repositories
{
    public interface ICartItemRepository : IRepository<CartItem>
    {
      // Return    : List<CartItem> 
      // Parameter : int id
       Task<List<CartItem>> GetByCustormerId(int id);
      // Parameter : List<CartItem> cartItems
       Task DeleteCartItems(List<CartItem> cartItems);
    }
}
