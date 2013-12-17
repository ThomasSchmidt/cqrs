using System.Web.Mvc;

namespace Valtech.Website.Areas.ShowProduct
{
	public class ProductsAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "ShowProduct";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
				"ShowProduct_default",
				"ShowProduct/{controller}/{action}/{id}",
				new { action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
