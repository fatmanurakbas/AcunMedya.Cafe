using AcunMedya.Cafe.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcunMedya.Cafe.ViewComponents
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        private readonly CafeContext _context;

        public _DefaultFeatureComponentPartial(CafeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var feature = _context.Features.FirstOrDefault();
            if (feature != null)
            {
                ViewBag.Subtitle = feature.SubTitle;
                ViewBag.Title = feature.Title;
                ViewBag.ImageUrl = feature.ImageUrl;
                ViewBag.ImageUrlbanner = feature.ImageUrlbanner;

            }
            return View();
        }
    }
}
