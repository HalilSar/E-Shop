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

namespace Eshop.Core.Application.Features.Commands.CreateCartItem
{
    public class CreateCartItemHandler:IRequestHandler<CreateCartItemRequest,CreateCartItemResponse>
    {
        ICartItemRepository _cartItemRepository;
        IMapper _mapper;
        public CreateCartItemHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
    }
          // Return CreateCartItemResponse
	  // Parameters: CreateCartItemRequest request, CancellationToken cancellationToken
        public async Task<CreateCartItemResponse> Handle(CreateCartItemRequest request, CancellationToken cancellationToken)
        {
           var cartItem= _mapper.Map<CartItem>(request);
           await _cartItemRepository.Add(cartItem);
            return new CreateCartItemResponse{ Success = "Başarılı" };
        }
    }
}
