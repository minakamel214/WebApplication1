using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ProductServices;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private IproductService _productService = new ProductServuce();
        public IActionResult Index()
        {

            var products = _productService.GetAllProducts();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product products)
        {
            _productService.AddProduct(products);

            return RedirectToAction("index");
                
        }

        public IActionResult Edit(int Id)
        {
            var product = _productService.GetProductById(Id);

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            _productService.UpdateProduct(product);
            return RedirectToAction("index");

        }

        public IActionResult Delete(int Id)
        {
            var product = _productService.GetProductById(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _productService.DeleteProduct(product.Id);

            return RedirectToAction("index");

        }
    }
}
