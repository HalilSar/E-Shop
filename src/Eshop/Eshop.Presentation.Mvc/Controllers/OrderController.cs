using Eshop.Core.Application.Features.Commands.CreateOrder;
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

        public IActionResult Cart(GetByCustormerIdCartItemRequest request)
        {        // Burayı güncelle. customerId sini nasıl user.id sistemine katarım.  
            return View(_mediatR.Send(request));
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CreateOrderRequest request)
        {         
            return View(_mediatR.Send(request));
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateCartItemRequest request)
        {
            return View(_mediatR.Send(request));
        }

        [HttpPost]
        public IActionResult Delete(DeleteCartItemRequest request)
        {
            return View(_mediatR.Send(request));
        }

    }
}
