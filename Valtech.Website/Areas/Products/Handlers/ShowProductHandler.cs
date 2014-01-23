using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Valtech.Cqrs;
using Valtech.Website.Areas.Products.Models;
using Valtech.Website.Areas.Products.Queries;

namespace Valtech.Website.Areas.Products.Handlers
{
	public class ShowProductHandler : IQueryHandler<ShowProductQuery,ShowProductViewModel>
	{
		public ShowProductViewModel Handle(ShowProductQuery query)
		{
			return new ShowProductViewModel{ProductName = "created in ShowProductHandler"};
		}
	}
}