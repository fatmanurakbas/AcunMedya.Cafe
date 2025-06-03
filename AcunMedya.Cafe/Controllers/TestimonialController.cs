using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly CafeContext _context;

        public TestimonialController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial model)
        {
            if (model.ImageFile != null)
            {
                var dir = Directory.GetCurrentDirectory();
                var ext = Path.GetExtension(model.ImageFile.FileName);
                var fileName = Guid.NewGuid().ToString();
                var savePath = Path.Combine(dir, "wwwroot/images", fileName + ext);
                using var stream = new FileStream(savePath, FileMode.Create);
                model.ImageFile.CopyTo(stream);
                model.imageUrl = "/images/" + fileName + ext;
            }

            _context.Testimonials.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial model)
        {
            if (model.ImageFile != null)
            {
                var dir = Directory.GetCurrentDirectory();
                var ext = Path.GetExtension(model.ImageFile.FileName);
                var fileName = Guid.NewGuid().ToString();
                var savePath = Path.Combine(dir, "wwwroot/images", fileName + ext);
                using var stream = new FileStream(savePath, FileMode.Create);
                model.ImageFile.CopyTo(stream);
                model.imageUrl = "/images/" + fileName + ext;
            }

            _context.Testimonials.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
