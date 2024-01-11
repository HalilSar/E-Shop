﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.CreateOrderProduct
{
   public class CreateOrderProductRequest : IRequest<CreateOrderProductResponse>
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double SubTotal { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
