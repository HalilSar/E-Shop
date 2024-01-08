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
        List<CartItem> GetByCustormerId(int id);
    }
}
