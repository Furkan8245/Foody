using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
	public class _DefaultHeadSectionComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();

		}
	}
}
