﻿using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Dto
{
     public  class CategoryIdProductDto
    {
        public List<Product> Products { get; set; }

        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}
