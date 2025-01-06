using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustomerIdOrders
{
   public class GetByCustomerIdOrdersHandler : IRequestHandler<GetByCustomerIdOrdersRequest, List<GetByCustomerIdOrdersResponse>>
    {
        IMapper _mapper;
        IOrderRepository _orderRepository;
        public GetByCustomerIdOrdersHandler(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }
        // Return     : List<GetByCustomerIdOrdersResponse>
	// Paramaters : GetByCustomerIdOrdersRequest request, CancellationToken cancellationToken
        public async Task<List<GetByCustomerIdOrdersResponse>> Handle(GetByCustomerIdOrdersRequest request, CancellationToken cancellationToken)
        {
           var order =await _orderRepository.GetByCustomerId(request.CategoryId);
           return _mapper.Map<List<GetByCustomerIdOrdersResponse>>(order);
        }
    }
}
