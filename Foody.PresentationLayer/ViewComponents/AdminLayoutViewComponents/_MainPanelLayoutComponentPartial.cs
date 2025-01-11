using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
