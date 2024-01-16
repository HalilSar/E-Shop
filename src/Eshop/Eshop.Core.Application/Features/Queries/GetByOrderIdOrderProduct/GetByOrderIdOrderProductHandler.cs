using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByOrderIdOrderProduct
{
    public  class GetByOrderIdOrderProductHandler : IRequestHandler<GetByOrderIdOrderProductRequest, List<GetByOrderIdOrderProductResponse>>
    {
        IMapper _mapper;
        IOrderProductRepository _orderProductRepository;
        public GetByOrderIdOrderProductHandler(IMapper mapper, IOrderProductRepository orderProductRepository)
        {
            _mapper = mapper;
            _orderProductRepository = orderProductRepository;
        }
        public async Task<List<GetByOrderIdOrderProductResponse>> Handle(GetByOrderIdOrderProductRequest request, CancellationToken cancellationToken)
        {
            var orderProduct = await _orderProductRepository.GetByOrderId(request.OrderId);
            return _mapper.Map<List<GetByOrderIdOrderProductResponse>>(orderProduct);
        }
    }
}
