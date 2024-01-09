using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdOrder
{
   public class GetByIdOrderRequest:IRequest<GetByIdOrderResponse>
    {
        public int Id { get; set; }
    }
}
