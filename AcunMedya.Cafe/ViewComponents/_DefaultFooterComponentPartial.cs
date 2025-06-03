using AcunMedya.Cafe.Context;
using AcunMedya.Cafe.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AcunMedya.Cafe.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        private readonly CafeContext _context;

        public _DefaultFooterComponentPartial(CafeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            // Sosyal medya linklerini çek
            var sosyalMedyaListesi = _context.SosyalMedyas.ToList();

            // Son 5 abone bilgisini de çek (isteğe bağlı)
            var sonAbonelikler = _context.Aboneliks
                .OrderByDescending(a => a.AbonelikId)
                .Take(5)
                .ToList();

            // ViewModel gibi ikili bir veri yapısı View’a gönder
            var viewModel = new FooterViewModel
            {
                SosyalMedyaListesi = sosyalMedyaListesi,
                SonAbonelikler = sonAbonelikler
            };

            return View(viewModel);
        }
    }

    // Footer için ViewModel (ViewComponent içinde tanımlı!)
    public class FooterViewModel
    {
        public List<SosyalMedya> SosyalMedyaListesi { get; set; }
        public List<Abonelik> SonAbonelikler { get; set; }
    }
}
