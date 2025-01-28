using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultCategorySectionComponentPartial:ViewComponent
    {
        private readonly ICategorySevice _categorySevice;

        public _DefaultCategorySectionComponentPartial(ICategorySevice categorySevice)
        {
            _categorySevice = categorySevice;
        }
        public IViewComponentResult Invoke()
        {
            var values= _categorySevice.TGetAll();
            return View(values);
        }
    }
}
