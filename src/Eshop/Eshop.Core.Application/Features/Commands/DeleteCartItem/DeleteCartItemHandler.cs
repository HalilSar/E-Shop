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

namespace Eshop.Core.Application.Features.Commands.DeleteCartItem
{
    public class DeleteCartItemHandler : IRequestHandler<DeleteCartItemRequest,DeleteCartItemResponse>
    {
        ICartItemRepository _cartItemRepository;
        IMapper _mapper;
        public DeleteCartItemHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
    }

        public async Task<DeleteCartItemResponse> Handle(DeleteCartItemRequest request, CancellationToken cancellationToken)
        {
           var cartItem= _mapper.Map<CartItem>(request);
           await _cartItemRepository.Delete(cartItem);
            return new DeleteCartItemResponse { Success = "Başarılı" };
        }
    }
}
