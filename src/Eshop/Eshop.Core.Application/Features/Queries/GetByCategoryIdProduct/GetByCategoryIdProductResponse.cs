using Eshop.Core.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct
{
   public class GetByCategoryIdProductResponse
    {
        public List<GetByCategoryIdProductDto> Products { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }

    }
}
