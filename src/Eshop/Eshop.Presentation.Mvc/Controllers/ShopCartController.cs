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
    }
}
