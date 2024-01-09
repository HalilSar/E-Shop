using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCategoryIdProductHandler
{
    public class GetByCategoryIdProductHandler : IRequestHandler<GetByIdProductRequest, GetByIdProductResponse>
    {
        IProductRepository _productRepository;
        IMapper _mapper;
        public GetByCategoryIdProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<GetByIdProductResponse> Handle(GetByIdProductRequest request, CancellationToken cancellationToken)
        {
            var product = _productRepository.GetById(request.Id);
           return  _mapper.Map<GetByIdProductResponse>(product);
           
        }
    }
}
