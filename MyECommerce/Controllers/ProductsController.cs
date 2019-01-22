using System.Linq;
using System.Web.Mvc;
using MyECommerce.Models;
using MyECommerce.ViewModels;

namespace MyECommerce.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult ProductForm()
        {
            var productCategories = _context.ProductCategories.ToList();

            var viewModel = new ProductFormViewModel
            {
                ProductCategories = productCategories
            };

            return View(viewModel);
        }

        // Add new product
        [HttpPost]
        public ActionResult Save(Product product)
        {
            if (product.Id == 0)
                _context.Products.Add(product);
            else
            {
                var productInDb = _context.Products.Single(p => p.Id == product.Id);
                productInDb.Name = product.Name;
                productInDb.Description = product.Description;
                productInDb.Price = product.Price;
                productInDb.Category_Id = product.Category_Id;
            }


            _context.SaveChanges();

            return RedirectToAction("Product", "Products");
        }

        // GET: Products
        public ActionResult Product()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                return HttpNotFound();

            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var products = _context.Products.SingleOrDefault(p => p.Id == id);

            if (products == null)
                return HttpNotFound();

            var viewModel = new ProductFormViewModel
            {
                Product = products,
                ProductCategories = _context.ProductCategories.ToList()

        };

            return View("ProductForm", viewModel);
        }
    }
}