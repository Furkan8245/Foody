using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
	public class _DefaultFeatureSectionComponentPartial:ViewComponent
	{
		private readonly IFeatureService _featureService;

		public _DefaultFeatureSectionComponentPartial(IFeatureService featureService)
		{
			_featureService = featureService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _featureService.TFeatureListByStatusTrue();
			return View(values);
		}
	}
}
