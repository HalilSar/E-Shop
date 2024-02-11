﻿using Eshop.Core.Application.Features.Queries.GetCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        private readonly IMediator _meditR;
        public CategoryViewComponent(IMediator meditR)
        {
            _meditR = meditR;
        }

        public async Task<List<GetCategoryResponse>> Invoke()
        {
           return  await _meditR.Send(new GetCategoryRequest());
        }
    }
}
