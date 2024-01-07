using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByIdOrderProduct
{
    public  class GetByIdOrderProductHandler : IRequestHandler<GetByIdOrderProductRequest,GetByIdOrderProductResponse>
    {
        IMapper _mapper;
        IOrderProductRepository _orderProductRepository;
        public GetByIdOrderProductHandler(IMapper mapper, IOrderProductRepository orderProductRepository)
        {
            _mapper = mapper;
            _orderProductRepository = orderProductRepository;
        }
        public async Task<GetByIdOrderProductResponse> Handle(GetByIdOrderProductRequest request, CancellationToken cancellationToken)
        {
            var orderProduct = _orderProductRepository.GetById(request.Id);
            return _mapper.Map<GetByIdOrderProductResponse>(orderProduct);
        }
    }
}
