using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustormerIdCartItem
{
    public class GetByCustormerIdCartItemHandler : IRequestHandler<GetByCustormerIdCartItemRequest, List<GetByCustormerIdCartItemResponse>>
    {
        ICartItemRepository _cartItemRepository;
        IMapper _mapper;
        public GetByCustormerIdCartItemHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<List<GetByCustormerIdCartItemResponse>> Handle(GetByCustormerIdCartItemRequest request, CancellationToken cancellationToken)
        {
            var cartItems = _cartItemRepository.GetByCustormerId(request.Id);
            return _mapper.Map<List<GetByCustormerIdCartItemResponse>>(cartItems);
        }
    }
}
