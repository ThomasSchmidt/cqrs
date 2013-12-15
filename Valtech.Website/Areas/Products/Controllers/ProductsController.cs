using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valtech.Cqrs;
using Valtech.Website.Areas.Products.Models;
using Valtech.Website.Areas.Products.Queries;

namespace Valtech.Website.Areas.Products.Controllers
{
    public class ProductsController : Controller
    {
	    private readonly IMediator _mediator;

	    public ProductsController(IMediator mediator)
	    {
		    _mediator = mediator;
	    }
        //
        // GET: /Products/Products/
        public ActionResult Index(ShowProductQuery query)
        {
	        ShowProductViewModel model = _mediator.Request(query);
            return View(model);
        }

    }
}
