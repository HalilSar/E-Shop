using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByOrderIdOrderProduct
{
    public  class GetByOrderIdOrderProductRequest : IRequest<List<GetByOrderIdOrderProductResponse>>
    {
        public int OrderId { get; set; }
    }
}
