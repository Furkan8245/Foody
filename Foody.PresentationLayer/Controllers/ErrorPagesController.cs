using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
