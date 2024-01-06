using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdProduct
{
    public  class GetByIdProductRequest:IRequest<GetByIdProductResponse>
    {
        public int Id { get; set; }
    }
}
