using Eshop.Core.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries
{
    public class GetProductResponse
    {
         public List<GetProductDto> ProductDtos { get; set; }

         public int ProductCount { get; set; }
         public int CurrentPage { get; set; }

    }
}
