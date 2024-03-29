﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Eshop.Core.Application.Features.Queries.GetProduct
{
    public class GetProductRequest : IRequest<GetProductResponse>
    {
        public int currentPage;
        public int perPageProductCount;
    }
}
