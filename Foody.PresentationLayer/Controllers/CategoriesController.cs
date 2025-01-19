using Foody.BusinessLayer.Abstract;
using Foody.EntitiyLayer.Concrete;
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
		[HttpGet]
		public IActionResult CreateCategory()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateCategory(Category category) 
		{
			_categorySevice.TInsert(category);
			return RedirectToAction("CategoryList");
		}
		public IActionResult DeleteCategory(int id)
		{
			_categorySevice.TDelete(id);
			return RedirectToAction("CategoryList");
		}
	}
}
