using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Areas.Admin.Controllers
{
  //  [Authorize]
    [Area("Admin")]
    public class SosyalMedyaController : Controller
    {
        private readonly CafeContext _context;

        public SosyalMedyaController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.SosyalMedyas.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddSosyalMedya()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSosyalMedya(SosyalMedya model)
        {
            _context.SosyalMedyas.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSosyalMedya(int id)
        {
            var item = _context.SosyalMedyas.Find(id);
            _context.SosyalMedyas.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSosyalMedya(int id)
        {
            var item = _context.SosyalMedyas.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult UpdateSosyalMedya(SosyalMedya model)
        {
            _context.SosyalMedyas.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
