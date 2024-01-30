using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using Eshop.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Commands.CreateOrderProduct
{
   public class CreateOrderProductHandler : IRequestHandler<CreateOrderProductRequest,CreateOrderProductResponse>
    {
        IOrderProductRepository _orderProductRepository;
        ICartItemRepository _cartItemRepository;
        IMapper _mapper;
        public CreateOrderProductHandler(IOrderProductRepository orderProductRepository, ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _orderProductRepository = orderProductRepository;
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<CreateOrderProductResponse> Handle(CreateOrderProductRequest request, CancellationToken cancellationToken)
        {
            var carts = await _cartItemRepository.GetByCustormerId(request.CustomerId);
            await _orderProductRepository.CreateOrderProducts(carts,request.CustomerId,request.OrderId);
            await _cartItemRepository.DeleteCartItems(carts);
            return new CreateOrderProductResponse { Success = "OrderProduct added." };
        }
    }
}
