using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultReviewSectionComponentPartial:ViewComponent
    {
        private readonly IReviewService _reviewService;

        public _DefaultReviewSectionComponentPartial(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }
        public IViewComponentResult Invoke()
        {

           var values = _reviewService.TGetAll();
            return View(values);
        }
      
    }
}
