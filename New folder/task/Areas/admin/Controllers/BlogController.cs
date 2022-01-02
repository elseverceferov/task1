using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using Task22_12_2021.Data;
using Task22_12_2021.Models;

namespace Task22_12_2021.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        //public IActionResult Index()
        //{
        //    return View(_context.Blogs.Include(u => u.User).Include(c => c.Category).ToList());
        //}

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog model)
        {
            string fileName = Guid.NewGuid() + "" + model.ImageFile.FileName;
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Upload", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }

            model.Image = fileName;
            model.CreateDate = DateTime.Now;
            //model.UserID = 1;
            _context.Blogs.Add(model);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }



        public IActionResult Update(int? id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View(_context.Blogs.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Blog model)
        {
            string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Upload", model.Image);
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            string fileName = Guid.NewGuid() + "" + model.ImageFile.FileName;
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Upload", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }

            model.Image = fileName;

            _context.Blogs.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            Blog blog = _context.Blogs.Find(id);

            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Upload", blog.Image);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
