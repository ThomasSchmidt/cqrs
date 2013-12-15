using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Valtech.Cqrs;
using Valtech.Website.Areas.Products.Models;

namespace Valtech.Website.Areas.Products.Queries
{
	public class ShowProductQuery : IQuery<ShowProductViewModel>
	{
		public string ProductId { get; set; }
	}
}