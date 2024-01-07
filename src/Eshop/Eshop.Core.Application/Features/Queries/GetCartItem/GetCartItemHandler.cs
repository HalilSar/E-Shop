using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetCartItem
{
    public class GetCartItemHandler : IRequestHandler<GetCartItemRequest, List<GetCartItemResponse>>
    {
        ICartItemRepository _cartItemRepository;
        IMapper _mapper;
        public GetCartItemHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }
        public async Task<List<GetCartItemResponse>> Handle(GetCartItemRequest request, CancellationToken cancellationToken)
        {
            var cartItems =_cartItemRepository.Get();
            return _mapper.Map<List<GetCartItemResponse>>(cartItems);
        }
    }
}
