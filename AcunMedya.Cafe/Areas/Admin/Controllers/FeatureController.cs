using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Areas.Admin.Controllers
{
   // [Authorize]
    [Area("Admin")]
    public class FeatureController : Controller
    {

        private readonly CafeContext _context;

        public FeatureController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeature(Feature model)
        {
            // ImageFile işlemi
            if (model.ImageFile != null)
            {
                var currentDir = Directory.GetCurrentDirectory();
                var ext = Path.GetExtension(model.ImageFile.FileName);
                var fileName = Guid.NewGuid().ToString();
                var path = Path.Combine(currentDir, "wwwroot/images", fileName + ext);
                using var stream = new FileStream(path, FileMode.Create);
                model.ImageFile.CopyTo(stream);
                model.ImageUrl = "/images/" + fileName + ext;
            }

            // Yeni alan: ImageFileBanner
            if (model.ImageFileBanner != null)
            {
                var currentDir = Directory.GetCurrentDirectory();
                var ext = Path.GetExtension(model.ImageFileBanner.FileName);
                var fileName = Guid.NewGuid().ToString();
                var path = Path.Combine(currentDir, "wwwroot/images", fileName + ext);
                using var stream = new FileStream(path, FileMode.Create);
                model.ImageFileBanner.CopyTo(stream);
                model.ImageUrlbanner = "/images/" + fileName + ext;
            }

            _context.Features.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = _context.Features.Find(id);
            _context.Features.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = _context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature model)
        {
            var existingFeature = _context.Features.Find(model.FeatureId);

            if (model.ImageFile != null)
            {
                var currentDir = Directory.GetCurrentDirectory();
                var ext = Path.GetExtension(model.ImageFile.FileName);
                var fileName = Guid.NewGuid().ToString();
                var path = Path.Combine(currentDir, "wwwroot/images", fileName + ext);
                using var stream = new FileStream(path, FileMode.Create);
                model.ImageFile.CopyTo(stream);
                existingFeature.ImageUrl = "/images/" + fileName + ext;
            }

            if (model.ImageFileBanner != null)
            {
                var currentDir = Directory.GetCurrentDirectory();
                var ext = Path.GetExtension(model.ImageFileBanner.FileName);
                var fileName = Guid.NewGuid().ToString();
                var path = Path.Combine(currentDir, "wwwroot/images", fileName + ext);
                using var stream = new FileStream(path, FileMode.Create);
                model.ImageFileBanner.CopyTo(stream);
                existingFeature.ImageUrlbanner = "/images/" + fileName + ext;
            }

            // Diğer alanlar için
            existingFeature.Title = model.Title;
            existingFeature.SubTitle = model.SubTitle;
            // ... varsa diğer alanlar

            _context.Features.Update(existingFeature);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
