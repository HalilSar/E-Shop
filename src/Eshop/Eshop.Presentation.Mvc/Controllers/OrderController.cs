﻿using Eshop.Core.Application.Features.Commands.CreateOrder;
using Eshop.Core.Application.Features.Queries.GetByCustomerIdOrder;
using Eshop.Core.Application.Features.Queries.GetByCustomerIdOrders;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IMediator _mediatR;

        public OrderController(ILogger<OrderController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }
        
       // Return OrderDetail.cshtml
       // Parameter GetByCustomerIdOrderRequest request
        public IActionResult OrderDetail(GetByCustomerIdOrderRequest request)
        {
            return View(_mediatR.Send(request));

        }// Cqrs design pattern nasıl kullanılacak, çünkü bunları tutan bir şey var mı

       // Return OrderList.cshtml
       // Parameter GetByCustomerIdOrdersRequest request
        public IActionResult OrderList(GetByCustomerIdOrdersRequest request)
        {
            return View(_mediatR.Send(request));

        }

       // Return AddOrder.cshtml
        public IActionResult AddOrder()
        {
            return View();
        }

       // Return AddOrder.cshtml
       // Parameter CreateOrderRequest request
        [HttpPost]
        public IActionResult AddOrder(CreateOrderRequest request)
        {         
            return View(_mediatR.Send(request));
        }


    }
}
