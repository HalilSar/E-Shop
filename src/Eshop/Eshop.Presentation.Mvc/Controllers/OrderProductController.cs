using Eshop.Core.Application.Features.Commands.CreateOrder;
using Eshop.Core.Application.Features.Commands.CreateOrderProduct;
using Eshop.Core.Application.Features.Queries.GetByCustomerIdOrder;
using Eshop.Core.Application.Features.Queries.GetByCustomerIdOrders;
using Eshop.Core.Application.Features.Queries.GetByOrderIdOrderProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.Controllers
{
    public class OrderProductController : Controller
    {
        private readonly ILogger<OrderProductController> _logger;
        private readonly IMediator _mediatR;

        public OrderProductController(ILogger<OrderProductController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }

        public IActionResult OrderProductList(GetByOrderIdOrderProductRequest request)
        {
            return View(_mediatR.Send(request));
        }


        [HttpPost]
        public IActionResult Add(CreateOrderProductRequest request)
        {
            var result = _mediatR.Send(request);
            if( result.Result.Success== true)
            {
                return RedirectToAction("OrderProducts",new GetByOrderIdOrderProductRequest { 
                OrderId=request.OrderId, CustomerId=request.CustomerId
                });
            }
            return View();
        }


    }
}
