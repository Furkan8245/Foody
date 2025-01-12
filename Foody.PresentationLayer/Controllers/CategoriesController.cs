using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ICategorySevice _categorySevice;

		public CategoriesController(ICategorySevice categorySevice)
		{
			_categorySevice = categorySevice;
		}

		public IActionResult CategoryList()
		{
			var values = _categorySevice.TGetAll();
			return View(values);
		}
	}
}
