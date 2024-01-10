﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustomerIdOrder
{
    public class GetByCustomerIdOrderRequest : IRequest<GetByCustomerIdOrderResponse>
    {
        public int Id { get;set;}
        public int CategoryId { get; set; }
    }
}