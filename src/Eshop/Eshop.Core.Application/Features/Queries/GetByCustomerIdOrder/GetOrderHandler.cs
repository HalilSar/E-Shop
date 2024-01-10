using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetOrder
{
    public class GetOrderHandler : IRequestHandler<GetOrderRequest, List<GetOrderResponse>>
    {
        IMapper _mapper;
        IOrderRepository _orderRepo;
        public GetOrderHandler(IMapper mapper, IOrderRepository order)
        {
            _mapper = mapper;
            _orderRepo = order;
        }
        public async Task<List<GetOrderResponse>> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            var orders =_orderRepo.Get();
            return _mapper.Map<List<GetOrderResponse>>(orders);
        }
    }
}
