using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedya.Cafe.Controllers
{
    public class AbonelikController : Controller
    {
        private readonly CafeContext _context;

        public AbonelikController(CafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Aboneliks.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAbonelik()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAbonelik(Abonelik model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Aboneliks.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbonelik(int id)
        {
            var value = _context.Aboneliks.Find(id);
            _context.Aboneliks.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
