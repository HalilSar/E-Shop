using Eshop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Dto
{
     public  class ProductDto
    {
        public List<Product> ProductDtos { get; set; }

        public int ProductCount { get; set; }
    }
}
