using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using MyECommerce.Models;
using MyECommerce.ViewModels;

namespace MyECommerce.Controllers
{
    public class ProductCategorysController : Controller
    {
        private ApplicationDbContext _context;

        public ProductCategorysController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: ProductCategorys
        public ViewResult Categories()
        {
            var categories = _context.ProductCategories.ToList();

            return View(categories);
        }

        [HttpPost]
        public ActionResult Save(ProductCategory category)
        {
            if (category.Id == 0)
                _context.ProductCategories.Add(category);
            else
            {
                var categoryInDb = _context.ProductCategories.Single(c => c.Id == category.Id);
                categoryInDb.Name = category.Name;
            }
            _context.SaveChanges();

            return RedirectToAction("Categories", "ProductCategorys");
        }

        public ActionResult CategoryForm()
        {
            return View();
        }  

        public ViewResult ProductCategory(int id)
        {
            var categories = _context.ProductCategories.SingleOrDefault(c => c.Id == id);

            var products = _context.Products.Where(p => p.Category_Id == categories.Id).ToList();

            if (categories == null) return null;
            var viewModel = new CategoryFormViewModel
            {
                Name = categories.Name,
                Products = products
            };
            return View(viewModel);

        }

        public ActionResult Edit(int id)
        {
            var category = _context.ProductCategories.SingleOrDefault(c => c.Id == id);

            if (category == null)
                return HttpNotFound();

            var viewModel = new CategoryFormViewModel
            {
               Name = category.Name
            };
            return View("CategoryForm", viewModel);
        }
    }
}