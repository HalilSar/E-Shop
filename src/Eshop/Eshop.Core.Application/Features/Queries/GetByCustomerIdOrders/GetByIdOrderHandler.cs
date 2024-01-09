using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdOrder
{
   public class GetByIdOrderHandler :IRequestHandler<GetByIdOrderRequest,GetByIdOrderResponse>
    {
        IMapper _mapper;
        IOrderRepository _orderRepository;
        public GetByIdOrderHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task<GetByIdOrderResponse> Handle(GetByIdOrderRequest request, CancellationToken cancellationToken)
        {
           var order = _orderRepository.GetById(request.Id);
           return _mapper.Map<GetByIdOrderResponse>(order);
        }
    }
}
