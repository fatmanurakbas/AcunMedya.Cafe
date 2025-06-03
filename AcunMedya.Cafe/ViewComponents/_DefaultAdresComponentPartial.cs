using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedya.Cafe.ViewComponents
{
    public class _DefaultAdresComponentPartial : ViewComponent
    {
        private readonly CafeContext _context;

        public _DefaultAdresComponentPartial(CafeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var adres = _context.Adress.FirstOrDefault();
            return View(adres);
        }
    }
}
