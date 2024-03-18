using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShopKnjiga.DataAccess.Data;
using WebShopKnjiga.Models.Models;

namespace WebShopKnjiga.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        { 
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit(int productId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int? productId)
        {
            Product? product = _context.Products.Where(x => x.Id == productId).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Product");
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product.Title.Length > 10)
            {
                ModelState.AddModelError("Name", "The name must not be longer than 10 characters.");
            }

            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }

            return View();
        }

     }
}

