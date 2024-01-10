using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.DeleteCartItem
{
     public class DeleteCartItemRequest : IRequest<DeleteCartItemResponse>
    {
        public int Id { get; set; }

    }
}
