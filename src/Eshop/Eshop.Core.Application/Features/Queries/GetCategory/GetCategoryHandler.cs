using AutoMapper;
using Eshop.Core.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshop.Core.Application.Features.Queries.GetCategory
{
    public class GetCategoryHandler : IRequestHandler<GetCategoryRequest, List<GetCategoryResponse>>
    {
        IMapper _mapper;
        ICategoryRepository _categoryRepository;
        public GetCategoryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
	// Return      : GetCategoryResponse
	// Parameters  : GetCategoryRequest request, CancellationToken cancellationToken
        public  async Task<List<GetCategoryResponse>> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
        {
            var categories =await _categoryRepository.Get();
            return _mapper.Map<List<GetCategoryResponse>>(categories);
        }
    }
}
