using Eshop.Core.Application.Features.Queries.GetByCategoryIdProduct;
using Eshop.Core.Application.Features.Queries.GetByIdProduct;
using Eshop.Core.Application.Features.Queries.GetProduct;
using Eshop.Presentation.Mvc.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediatR;

        public HomeController(ILogger<HomeController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }

        public IActionResult Index(int id = 1)
        {

            var products = _mediatR.Send(new GetProductRequest{  currentPage=id,
                                                                   perPageProductCount=4
                                                                });
                                                                
            return View(products.Result);
        }

        public IActionResult Detail(GetByIdProductRequest request)
        {
            var products = _mediatR.Send(request);
            return View(products.Result);
        }
        public IActionResult GetByCategoryId(GetByCategoryIdProductResquest request)
        {
            request.perPageProduct = 4;
            var products = _mediatR.Send(request);
            return View(products.Result);
        }

    }
}
