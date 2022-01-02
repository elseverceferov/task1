using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Task22_12_2021.Data;
using Task22_12_2021.Models;

namespace Task22_12_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Category model)
        {
            _context.Categories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        



        public IActionResult Update(int id)
        {
            return View(_context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            _context.Categories.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            Category category = _context.Categories.Find(id);

            bool IsRelation = _context.Blogs.Any(c => c.CategoryID == category.ID);

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
