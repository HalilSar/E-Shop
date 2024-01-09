using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetOrderProduct
{
    public class GetOrderProducHandler : IRequestHandler<GetOrderProductResquest, List<GetOrderProductResponse>>
    {
        IMapper _mapper;
        IOrderProductRepository _orderProductRepository;
        public GetOrderProducHandler(IMapper mapper, IOrderProductRepository orderProductRepository)
        {
            _mapper = mapper;
            _orderProductRepository = orderProductRepository;
        }
        public async Task<List<GetOrderProductResponse>> Handle(GetOrderProductResquest request, CancellationToken cancellationToken)
        {
            var orderProducts = _orderProductRepository.Get();
            return _mapper.Map<List<GetOrderProductResponse>>(orderProducts);
        }
    }
}
