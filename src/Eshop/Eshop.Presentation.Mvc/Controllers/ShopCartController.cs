using Eshop.Core.Application.Features.Commands.CreateCartItem;
using Eshop.Core.Application.Features.Commands.UpdateCartItem;
using Eshop.Core.Application.Features.Queries.GetByCustormerIdCartItem;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Presentation.Mvc.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly ILogger<ShopCartController> _logger;
        private readonly IMediator _mediatR;

        public ShopCartController(ILogger<ShopCartController> logger, IMediator mediatR)
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
        public IActionResult Add(CreateCartItemRequest request)
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


    }
}
