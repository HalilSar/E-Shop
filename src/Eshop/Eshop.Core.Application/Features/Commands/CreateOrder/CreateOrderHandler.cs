﻿using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.CreateOrder
{
   public class CreateOrderHandler:IRequestHandler<CreateOrderRequest,CreateOrderResponse>
    {
        IOrderRepository _orderRepository;
        IOrderProductRepository _orderProductRepository;
        IMapper _mapper;
        public CreateOrderHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<CreateOrderResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            // var carts =_applicationDbContext.CartItems.Where(i=>i.CustomerId==customerId);
            var order = _mapper.Map<Order>(request);
           await _orderRepository.Add(order);
            return new CreateOrderResponse { Success = "Order eklendi" };
        }
    }
}
