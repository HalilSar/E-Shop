using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct
{
   public class GetByCategoryIdProductResquest : IRequest<List<GetByCategoryIdProductResponse>>
    {

        public int CategoryId { get; set; }
        public int perPageProduct;
        public int currentPage;
    }
}
