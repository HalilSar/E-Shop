using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct
{
    public class GetByCategoryIdProductHandler : IRequestHandler<GetByCategoryIdProductResquest, List<GetByCategoryIdProductResponse>>
    {
        IMapper _mapper;
        IProductRepository _productRepository;
        public GetByCategoryIdProductHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<List<GetByCategoryIdProductResponse>> Handle(GetByCategoryIdProductResquest request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetByCatId(request.CategoryId);
            return _mapper.Map<List<GetByCategoryIdProductResponse>>(products);
        }

    }
}
