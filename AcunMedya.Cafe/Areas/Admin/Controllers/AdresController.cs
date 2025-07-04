using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class AdresController : Controller
    {
        private readonly CafeContext _context;

        public AdresController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Adress.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdres()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdres(Adres model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Adress.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAdres(int id)
        {
            var adres = _context.Adress.Find(id);
            return View(adres);
        }

        [HttpPost]
        public IActionResult UpdateAdres(Adres model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Adress.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdres(int id)
        {
            var value = _context.Adress.Find(id);
            if (value != null)
            {
                _context.Adress.Remove(value);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Eğer bulunamazsa hata sayfası veya yönlendirme
            return NotFound(); // veya View("Error");
        }

    }
}
