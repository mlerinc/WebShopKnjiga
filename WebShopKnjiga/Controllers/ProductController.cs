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

        [HttpPost]
        public IActionResult Create(Category product)
        {
            if (product.Name.Length > 10)
            {
                ModelState.AddModelError("Name", "The name must not be longer than 10 characters.");
            }

            if (product.Name == product.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "The display order cant't be the same as name.");
            }

            if (ModelState.IsValid)
            {
                _context.Categories.Add(product);
                _context.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index", "Category");
            }

            return View();
        }

     }
}

