using Foody.BusinessLayer.Abstract;
using Foody.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Foody.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategorySevice _categorySevice;
        public ProductsController(IProductService productService, ICategorySevice categorySevice)
        {
            _productService = productService;
            _categorySevice = categorySevice;
        }

        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            return View(values);
        }
        public IActionResult ProductListWithCategory()
        {
            var values = _productService.TProductListWithCategory();
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            var values=_categorySevice.TGetAll();
            ViewBag.categories = new SelectList(values, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("ProductListWithCategory");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _categorySevice.TGetAll();
            ViewBag.categories = new SelectList(values, "CategoryId", "CategoryName");
            var productValues = _productService.TGetById(id);
            return View(productValues);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("ProductListWithCategory");

        }
    }
}
