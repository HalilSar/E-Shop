using Eshop.Core.Application.Features.Commands.CreateCartItem;
using Eshop.Core.Application.Features.Commands.DeleteCartItem;
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
        // Result Add.cshtml
        public IActionResult Add()
        {
            return View();
        }
        // Result Add.cshtml
        // Parameter CreateCartItemRequest request	
        [HttpPost]
        public IActionResult Add(CreateCartItemRequest request)
        {         
            return View(_mediatR.Send(request));
        }
	// Return Update.cshtml
        public IActionResult Update()
        {
            return View();
        }
	// Return Update.cshtml
        // Parameter UpdateCartItemRequest request
        [HttpPost]
        public IActionResult Update(UpdateCartItemRequest request)
        {
            return View(_mediatR.Send(request));
        }
        // Return View
	// Parameter DeleteCartItemRequest request
        [HttpPost]
        public IActionResult Delete(DeleteCartItemRequest request)
        {
            return View(_mediatR.Send(request));
        }

    }
}
