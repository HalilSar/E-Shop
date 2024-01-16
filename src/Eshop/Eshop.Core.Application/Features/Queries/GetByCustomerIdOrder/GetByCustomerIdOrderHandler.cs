using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCustomerIdOrder
{
    public class GetByCustomerIdOrderHandler : IRequestHandler<GetByCustomerIdOrderRequest, GetByCustomerIdOrderResponse>
    {
        IMapper _mapper;
        IOrderRepository _orderRepo;
        public GetByCustomerIdOrderHandler(IMapper mapper, IOrderRepository order)
        {
            _mapper = mapper;
            _orderRepo = order;
        }
        public async Task<GetByCustomerIdOrderResponse> Handle(GetByCustomerIdOrderRequest request, CancellationToken cancellationToken)
        {
            var order =await _orderRepo.GetByCustomerIdOrder(request.Id,request.CategoryId);
            return _mapper.Map<GetByCustomerIdOrderResponse> (order);
        }
    }
}
