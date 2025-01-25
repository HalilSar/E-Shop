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

namespace Eshop.Core.Application.Features.Commands.UpdateCartItem
{
    public class UpdateCartItemHandler : IRequestHandler<UpdateCartItemRequest,UpdateCartItemResponse>
    {
        ICartItemRepository _cartItemRepository;
        IMapper _mapper;
        public UpdateCartItemHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }
       // Return     : UpdateCartItemResponse
       // Parameters : UpdateCartItemRequest request, CancellationToken cancellationToken
        public async Task<UpdateCartItemResponse> Handle(UpdateCartItemRequest request, CancellationToken cancellationToken)
        {
           var cartItem= _mapper.Map<CartItem>(request);
           await _cartItemRepository.Update(cartItem);
            return new UpdateCartItemResponse{ Success = "Başarılı" };
        }
    }
}
