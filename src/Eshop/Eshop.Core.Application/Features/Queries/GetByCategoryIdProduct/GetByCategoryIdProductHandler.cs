using AutoMapper;
using Eshop.Core.Application.Dto;
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
    public class GetByCategoryIdProductHandler : IRequestHandler<GetByCategoryIdProductResquest, GetByCategoryIdProductResponse>
    {
        IMapper _mapper;
        IProductRepository _productRepository;
        public GetByCategoryIdProductHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        // Return     : GetByCategoryIdProductResponse
	// Parameters : GetByCategoryIdProductResquest request, CancellationToken cancellationToken
        public async Task<GetByCategoryIdProductResponse> Handle(GetByCategoryIdProductResquest request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetByCatId(request.CategoryId,request.perPageProduct,request.currentPage);
            return new GetByCategoryIdProductResponse
            {
                Products = _mapper.Map<List<GetByCategoryIdProductDto>>(products.Products),
                CurrentPage = products.CurrentPage,
                PageCount= products.PageCount
            };

        }

    }
}
