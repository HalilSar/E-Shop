﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetCartItem
{
    public  class GetCartItemRequest:IRequest<List<GetCartItemResponse>>
    {
    }
}
