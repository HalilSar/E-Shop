using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustormerIdCartItem
{
    public  class GetByCustormerIdCartItemRequest : IRequest<List<GetByCustormerIdCartItemResponse>>
    {
        public int Id { get; set; }
    }
}
