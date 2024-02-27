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

namespace Eshop.Core.Application.Features.Queries.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductRequest, GetProductResponse>
    {

        IProductRepository _productRepository;
        IMapper _mapper;
        public GetProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;

        }
        public async Task<GetProductResponse> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            var products =await  _productRepository.GetPerPageProducts(request.perPageProductCount, request.currentPage);
             return new GetProductResponse { 
                        ProductDtos= _mapper.Map<List<GetProductDto>>(products),
                 //       ProductCount=products.
             
                        };
           
        }
    }
}
